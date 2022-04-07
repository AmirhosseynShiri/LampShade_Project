using DiscountManagement.Application.Contract.ColleagueDiscount;
using DiscountManagement.Application.Contract.CustomerDiscount;
using DiscountManagement.Domain.ColleagueDiscountAgg;
using DiscountManagement.Domain.CustomerDiscountAgg;
using DiscountManagement.Infrustructure.EfCore;
using DiscountManagement.Infrustructure.EfCore.Repository;
using DiscountMangement.Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DiscountManagement.Configuration
{
    public class DiscountManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ICustomerDiscountApplication,CustomerDiscountApplication>();
            services.AddTransient<ICustomerDiscountRepository, CustomerDiscountRepository>();


            services.AddTransient<IColleagueDiscountApplication, ColleageDiscountApplication>();
            services.AddTransient<IColleagueDiscountRepository, ColleageDiscountRepository>();

            services.AddDbContext<DiscountContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
