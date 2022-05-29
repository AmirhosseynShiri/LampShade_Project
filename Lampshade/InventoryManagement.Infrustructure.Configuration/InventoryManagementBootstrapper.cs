using _0_FrameWork.Infrastructure;
using InventoryManagement.Application;
using InventoryManagement.Application.Contract.Inventory;
using InventoryManagement.Infrustructure.Configuration.Permissions;
using InventoryManagement.Infrustructure.EfCore;
using InventoryManagement.Infrustructure.EfCore.Repository;
using InventoryMangement.Domain.InventoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace InventoryManagement.Infrustructure.Configuration
{
    public class InventoryManagementBootstrapper
    {
        public static void Configure(IServiceCollection services,string connectionString)
        {
            services.AddTransient<IInventoryRepository, InventoryRepository>();
            services.AddTransient<IInventoryApplication, InventoryApplication>();


            services.AddTransient<IPermissionExposer, InventoryPermissionExposer>();

            services.AddDbContext<InventoryContext>(x=>x.UseSqlServer(connectionString));
        }
    }
}
