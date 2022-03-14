using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShioManagement.Infrastructure.EfCore;
using ShioManagement.Infrastructure.EfCore.Repository;
using ShopManagement.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;
using System;

namespace ShopManagement.Configuration
{
    public class ShopManagementBootstrapper
    {
        public static void Configure(IServiceCollection services,string connectionString)
        {
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();

            services.AddDbContext<ShopContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
