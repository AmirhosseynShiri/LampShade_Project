using _0_FrameWork.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Configuration.Permissions;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Shop.ProductCategories
{
    public class IndexModel : PageModel
    {
        public List<ProductCategoryViewModel> ProductCategories;
        public ProductCategorySearchModel SearchModel;

        private readonly IProductCategoryApplication _productCategoryApplication;

        public IndexModel(IProductCategoryApplication productCategoryApplication)
        {
            _productCategoryApplication = productCategoryApplication;
        }

        [NeedsPermission(ShopPermissions.ListProductCategories)]
        public void OnGet(ProductCategorySearchModel searchModel)
        {
            ProductCategories = _productCategoryApplication.Search(searchModel);
        }

        [NeedsPermission(ShopPermissions.CreateProductCategory)]
        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateProductCategory());
        }

        [NeedsPermission(ShopPermissions.CreateProductCategory)]
        public JsonResult OnPostCreate(CreateProductCategory command)
        {
            var result = _productCategoryApplication.Create(command);
            return new JsonResult(result);
        }

        [NeedsPermission(ShopPermissions.EditProductCategory)]
        public IActionResult OnGetEdit(long id)
        {
            var productCategory = _productCategoryApplication.GetDetails(id);
            return Partial("Edit", productCategory);
        }

        [NeedsPermission(ShopPermissions.EditProductCategory)]
        public JsonResult OnPostEdit(EditProductCategory command)
        {
            var result=_productCategoryApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
