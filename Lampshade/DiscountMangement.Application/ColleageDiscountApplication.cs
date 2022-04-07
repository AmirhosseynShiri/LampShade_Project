using _0_FrameWork.Application;
using DiscountManagement.Application.Contract.ColleagueDiscount;
using DiscountManagement.Domain.ColleagueDiscountAgg;
using System;
using System.Collections.Generic;

namespace DiscountMangement.Application
{
    public class ColleageDiscountApplication : IColleagueDiscountApplication
    {
        private readonly IColleagueDiscountRepository _colleagueDiscountRepository;

        public OperationResult Define(DefineColleagueDiscount command)
        {
            var operationResult=new OperationResult();
            if (_colleagueDiscountRepository.Exists(x => x.ProductId == command.ProductId && x.DiscountRate == command.DiscountRate))
                return operationResult.Failed(ApplicationMessages.DuplicatedRecord);

            var colleageDiscount=new ColleagueDiscount(command.ProductId, command.DiscountRate);
            _colleagueDiscountRepository.Create(colleageDiscount);
            _colleagueDiscountRepository.SaveChanges();

            return operationResult.Succedded();
        }

        public OperationResult Edit(EditColleagueDiscount command)
        {
            var operationResult = new OperationResult();
            var colleageDicount = _colleagueDiscountRepository.Get(command.Id);
            if (colleageDicount == null)
                return operationResult.Failed(ApplicationMessages.RecordNotFound);

            if (_colleagueDiscountRepository.Exists(x => x.ProductId == command.ProductId && x.DiscountRate == command.DiscountRate&&x.Id!=command.Id))
                return operationResult.Failed(ApplicationMessages.DuplicatedRecord);

            colleageDicount.Edit(command.ProductId, command.DiscountRate);
            _colleagueDiscountRepository.SaveChanges();

            return operationResult.Succedded();
        }

        public EditColleagueDiscount GetDetails(long id)
        {
            return _colleagueDiscountRepository.GetDetails(id);
        }

        public OperationResult Remove(long id)
        {
            var operationResult = new OperationResult();
            var colleagueDicount = _colleagueDiscountRepository.Get(id);
            if (colleagueDicount == null)
                return operationResult.Failed(ApplicationMessages.RecordNotFound);

            colleagueDicount.Removed();
            _colleagueDiscountRepository.SaveChanges();

            return operationResult.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operationResult = new OperationResult();
            var colleagueDicount = _colleagueDiscountRepository.Get(id);
            if (colleagueDicount == null)
                return operationResult.Failed(ApplicationMessages.RecordNotFound);

            colleagueDicount.Restore();
            _colleagueDiscountRepository.SaveChanges();

            return operationResult.Succedded();
        }

        public List<ColleagueDiscountViewModel> Search(ColleagueDiscountSearchModel searchModel)
        {
            return _colleagueDiscountRepository.Search(searchModel);
        }
    }
}
