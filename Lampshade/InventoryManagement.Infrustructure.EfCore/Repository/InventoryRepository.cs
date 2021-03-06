using _0_Framework.Application;
using _0_FrameWork.Application;
using _0_FrameWork.Infrastructure;
using AccountManagement.Infrastructure.EfCore;
using InventoryManagement.Application.Contract.Inventory;
using InventoryMangement.Domain.InventoryAgg;
using Microsoft.EntityFrameworkCore;
using ShioManagement.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Infrustructure.EfCore.Repository
{
    public class InventoryRepository : RepositoryBase<long, Inventory>, IInventoryRepository
    {
        private readonly InventoryContext _inventoryContext;
        private readonly ShopContext _shopContext;
        private readonly AccountContext _accountContext;

        public InventoryRepository(InventoryContext inventoryContext, ShopContext shopContext, AccountContext accountContext) : base(inventoryContext)
        {
            _inventoryContext = inventoryContext;
            _shopContext = shopContext;
            _accountContext = accountContext;
        }

        public Inventory GetBy(long productId)
        {
            return _inventoryContext.Inventory.FirstOrDefault(x => x.ProductId == productId);
        }

        public EditInventory GetDetails(long id)
        {
            return _inventoryContext.Inventory.Select(x => new EditInventory 
            {
            Id=x.Id,
            ProductId=x.ProductId,
            UnitPrice=x.UnitPrice
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<InventoryOperationViewModel> GetOperationLog(long inventoryId)
        {
            var inventory = _inventoryContext.Inventory.FirstOrDefault(x => x.Id == inventoryId);
            var accounts = _accountContext.Accounts.Select(x => new { x.Id, x.FullName }).ToList();

            var operations= inventory.Operations.Select(x => new InventoryOperationViewModel
            {
                Id = x.Id,
                Count=x.Count,
                CurrentCount=x.CurrentCount,
                Description=x.Description,
                Operation=x.Operation,
                OperationDate=x.OperationDate.ToFarsi(),
                OperatorId=x.OperatorId,
                OrderId=x.OrderId

            }).OrderByDescending(x => x.Id).ToList();
            foreach (var operation in operations)
            {
                operation.Operator = accounts.FirstOrDefault(x => x.Id == operation.OperatorId)?.FullName;
            }

            return operations;
            
        }

        public List<InventoryViewModel> Search(InventorySearchModel searchModel)
        {
            var products = _shopContext.Products.Select(x => new { x.Id, x.Name }).ToList();
            var query = _inventoryContext.Inventory.Select(x => new InventoryViewModel
            {
                Id= x.Id,
                InStock=x.InStock,
                CurrentCount=x.CalculateCurrentCount(),
                ProductId=x.ProductId,
                UnirPrice=x.UnitPrice,
                CreationDate=x.CreationDate.ToFarsi()

            });

            if(searchModel.ProductId>0)
                query=query.Where(x=>x.ProductId==searchModel.ProductId);

            if (searchModel.InStock)
                query = query.Where(x => !x.InStock);

            var inventory = query.OrderByDescending(x => x.Id).ToList();

            inventory.ForEach(item =>
             item.Product = products.FirstOrDefault(x => x.Id == item.ProductId)?.Name);

            return inventory;


        }
    }
}
