﻿using _0_FrameWork.Infrastructure;
using System.Collections.Generic;

namespace ShopManagement.Configuration.Permissions
{
    public class ShopPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {"Product",new List<PermissionDto>
                  {
                    new PermissionDto(ShopPermissions.ListProducts,"ListProducts"),
                    new PermissionDto(ShopPermissions.SearchProducts,"SearchProducts"),
                    new PermissionDto(ShopPermissions.CreateProduct,"CreateProduct"),
                    new PermissionDto(ShopPermissions.EditProduct,"EditProduct"),
                   }
                },
                {"ProductCateory",new List<PermissionDto>
                  {
                    new PermissionDto(ShopPermissions.ListProductCategories,"ListProductCategories"),
                    new PermissionDto(ShopPermissions.SearchProductCategories,"SearchProductCateories"),
                    new PermissionDto(ShopPermissions.CreateProductCategory,"CreateProductCategory"),
                    new PermissionDto(ShopPermissions.EditProductCategory,"EditProductCategory"),
                   }
                }

            };
        }
    }
}
