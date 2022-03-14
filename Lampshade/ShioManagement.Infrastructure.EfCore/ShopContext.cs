using Microsoft.EntityFrameworkCore;
using ShioManagement.Infrastructure.EfCore.Mapping;
using ShopManagement.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShioManagement.Infrastructure.EfCore
{
   public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options):base(options)
        {

        }

        public DbSet<ProductCategory> ProductCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ProductCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
