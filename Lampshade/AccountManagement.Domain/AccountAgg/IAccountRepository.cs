using _0_FrameWork.Domain;
using AccountManagement.Appllication.Contract.Account;
using System.Collections.Generic;

namespace AccountManagement.Domain.AccountAgg
{
    public interface IAccountRepository:IRepository<long,Account>
    {
        EditAccount GetDetails(long id);
        Account GetBy(string userName);
        List<AccountViewModel> Search(AccountSearchModel searchModel);
        List<AccountViewModel> GetAccounts();
    }
}
