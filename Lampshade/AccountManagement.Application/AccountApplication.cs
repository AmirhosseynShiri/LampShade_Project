using _0_Framework.Application;
using _0_FrameWork.Application;
using AccountManagement.Appllication.Contract.Account;
using AccountManagement.Domain.AccountAgg;
using System;
using System.Collections.Generic;

namespace AccountManagement.Application
{
    public class AccountApplication : IAccountApplication
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IFileUploader _fileUploader;
        private readonly IAuthHelper _authHelper;


        public AccountApplication(IAccountRepository accountRepository, IFileUploader fileUploader, IPasswordHasher passwordHasher, IAuthHelper authHelper)
        {
            _accountRepository = accountRepository;
            _fileUploader = fileUploader;
            _passwordHasher = passwordHasher;
            _authHelper = authHelper;
        }

        public OperationResult ChangePassword(ChangePassword command)
        {
            var operationResult=new OperationResult();
            var account = _accountRepository.Get(command.Id);

            if (account == null)
                return operationResult.Failed(ApplicationMessages.RecordNotFound);

            if (command.Password != command.RePassword)
                return operationResult.Failed(ApplicationMessages.PasswordNotMath);

            var password = _passwordHasher.Hash(command.Password);

            account.ChangePassword(password);
            _accountRepository.SaveChanges();
            return operationResult.Succedded();

        }

        public OperationResult Create(CreateAccount command)
        {
            var operationResult = new OperationResult();
            if (_accountRepository.Exists(x => x.UserName == command.UserName || x.Mobile == command.Mobile))
                return operationResult.Failed(ApplicationMessages.DuplicatedRecord);

            var password = _passwordHasher.Hash(command.Password);
            var path = $"ProfilePhoto";
            var picturePath = _fileUploader.Upload(command.ProfilePhoto, path);
            var account = new Account(command.FullName, command.UserName, password, command.Mobile, command.RoleId,picturePath);

            _accountRepository.Create(account);
            _accountRepository.SaveChanges();

            operationResult.Succedded();
            return operationResult.Succedded();
        }

        public OperationResult Edit(EditAccount command)
        {
            var operationResult = new OperationResult();
            var account = _accountRepository.Get(command.Id);

            if (account == null)
                return operationResult.Failed(ApplicationMessages.RecordNotFound);

            if (_accountRepository.Exists(x=>(x.UserName==command.UserName||x.Mobile==command.Mobile)&&x.Id!=command.Id))
                return operationResult.Failed(ApplicationMessages.DuplicatedRecord);

            var path = $"ProfilePhoto";
            var picturePath = _fileUploader.Upload(command.ProfilePhoto, path);

            account.Edit(command.FullName, command.UserName, command.Mobile, command.RoleId, picturePath);
            _accountRepository.SaveChanges();
            return operationResult.Succedded();
        }

        public EditAccount GetDetails(long id)
        {
           return _accountRepository.GetDetails(id);
        }

        public OperationResult Login(Login command)
        {
            var operation=new OperationResult();
            var account = _accountRepository.GetBy(command.UserName);
            if(account == null)
                return operation.Failed(ApplicationMessages.WrongUserPass);

            (bool Verified, bool NeedsUpgrade) result = _passwordHasher.Check(account.Password, command.Password);

            if (!result.Verified)
                return operation.Failed(ApplicationMessages.WrongUserPass);

            var authViewModel = new AuthViewModel(account.Id, account.RoleId, account.FullName,
                account.UserName, account.Mobile);
            _authHelper.SignIn(authViewModel);

            return operation.Succedded();
        }

        public void Logout()
        {
            _authHelper.SignOut();
        }

        public List<AccountViewModel> Search(AccountSearchModel searchModel)
        {
            return _accountRepository.Search(searchModel);
        }
    }
}
