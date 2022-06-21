using ShopManagement.Application.Contracts.Order;
using System.Collections.Generic;

namespace _01_LampshadeQuery.Contract.Product
{
    public interface IProductQuery
    {
        List<ProductQueryModel> GetLatestArrivals();
        ProductQueryModel GetProductDetails(string slug);
        List<ProductQueryModel> Search(string value);
        List<CartItem> CheckInventoryStatus(List<CartItem> cartItems);
    }
}
