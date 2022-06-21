using _01_LampshadeQuery.Contract.Inventory;
using InventoryManagement.Infrustructure.EfCore;
using ShioManagement.Infrastructure.EfCore;
using System.Linq;

namespace _01_LampshadeQuery.Query
{
    public class InventoryQuery : IInventoryQuery
    {
        private readonly ShopContext _shopContext;
        private readonly InventoryContext _inventoryContext;

        public InventoryQuery(InventoryContext inventoryContext, ShopContext shopContext)
        {
            _inventoryContext = inventoryContext;
            _shopContext = shopContext;
        }

        public StatusStock CheckStock(IsInStock command)
        {
            var inventory = _inventoryContext.Inventory.FirstOrDefault(x => x.Id == command.ProductId);
            if(inventory == null || inventory.CalculateCurrentCount() < command.Count)
            {
                var product = _shopContext.Products.Select(x => new { x.Id, x.Name })
                    .FirstOrDefault(x => x.Id == command.ProductId);
                return new StatusStock
                {
                    IsStock = false,
                    ProductName = product.Name
                };
            }

            return new StatusStock
            {
                IsStock = true
            };
        }
    }
}
