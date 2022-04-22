
using System.Collections.Generic;


namespace _01_LampshadeQuery.Contract.ProductCategory
{
    public interface IProductCategoryQuery
    {
        List<ProductCategoryQueryModel> GetProductCategories();
        List<ProductCategoryQueryModel> GetProductCategoriesWithProduct();
        ProductCategoryQueryModel GetProductCategoryWithProductsBy(string slug);
    }
}
