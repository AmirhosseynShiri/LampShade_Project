
using _0_FrameWork.Application;
using _0_FrameWork.Infrastructure;
using InventoryManagement.Application.Contract.Inventory;
using InventoryManagement.Infrustructure.Configuration.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Inventory
{
    [Authorize(Roles =Roles.Administration)]
    public class IndexModel : AdminBaseRazorPageModel
    {
        public List<InventoryViewModel> Inventory;
        public InventorySearchModel SearchModel;
        public SelectList Products;

        private readonly IProductApplication _productApplication;
        private readonly IInventoryApplication _inventoryApplication;

        public IndexModel(IProductApplication productApplication, IInventoryApplication inventoryApplication)
        {
            _productApplication = productApplication;
            _inventoryApplication = inventoryApplication;
        }

        [NeedsPermission(InventoryPermissions.ListInventory)]
        public void OnGet(InventorySearchModel searchModel)
        {
            Products = new SelectList(_productApplication.GetProducts(), "Id", "Name");
            Inventory = _inventoryApplication.Search(searchModel);
        }

        [NeedsPermission(InventoryPermissions.CreateInventory)]
        public IActionResult OnGetCreate()
        {
            var command = new CreateInventory
            {
                Products = _productApplication.GetProducts()
            };
            return Partial("./Create", command);
        }

        [NeedsPermission(InventoryPermissions.CreateInventory)]
        public JsonResult OnPostCreate(CreateInventory command)
        {
            var result = _inventoryApplication.Create(command);
            return new JsonResult(result);
        }

        [NeedsPermission(InventoryPermissions.EditInventory)]
        public IActionResult OnGetEdit(long id)
        {
            var inventory = _inventoryApplication.GetDetails(id);
            inventory.Products = _productApplication.GetProducts();
            return Partial("Edit", inventory);
        }

        [NeedsPermission(InventoryPermissions.EditInventory)]
        public JsonResult OnPostEdit(EditInventory command)
        {
            var result = _inventoryApplication.Edit(command);
            return new JsonResult(result);
        }

        [NeedsPermission(InventoryPermissions.Increase)]
        public IActionResult OnGetIncrease(long id)
        {
            var command = new IncreaseInventory
            {
                InventoryId = id
            };
            return Partial("Increase", command);
        }

        [NeedsPermission(InventoryPermissions.Increase)]
        public JsonResult OnPostIncrease(IncreaseInventory command)
        {
            var result = _inventoryApplication.Increase(command);
            return new JsonResult(result);
        }

        [NeedsPermission(InventoryPermissions.Reduce)]
        public IActionResult OnGetReduse(long id)
        {
            var command = new ReduceInventory
            {
                InventoryId = id
            };
            return Partial("Reduse", command);
        }

        [NeedsPermission(InventoryPermissions.Reduce)]
        public JsonResult OnPostReduse(ReduceInventory command)
        {
            var result = _inventoryApplication.Reduce(command);
            return new JsonResult(result);
        }

        [NeedsPermission(InventoryPermissions.OperationLog)]
        public IActionResult OnGetLog(long id)
        {
            var inventory=_inventoryApplication.GetOperationLog(id);
            return Partial("OperationLog", inventory);
        }


    }
}
