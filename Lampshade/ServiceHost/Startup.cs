using _0_Framework.Application;
using _0_FrameWork.Application;
using AccountManagement.Infrastructure.Configuration;
using BlogManagement.Infrastructure.Configuration;
using CommentManagement.Infrastructure.Configuration;
using DiscountManagement.Configuration;
using InventoryManagement.Infrustructure.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopManagement.Configuration;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace ServiceHost
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("LampshadeDb");
            ShopManagementBootstrapper.Configure(services, connectionString);
            DiscountManagementBootstrapper.Configure(services, connectionString);
            InventoryManagementBootstrapper.Configure(services, connectionString);
            BlogManagementBootstrapper.Configure(services, connectionString);
            CommentManagementBootstrapper.Configure(services, connectionString);
            AccountManagementBootstrapper.Configure(services, connectionString);

            services.AddHttpContextAccessor();
            services.AddTransient<IFileUploader, FileUploader>();
            services.AddSingleton<IPasswordHasher, PasswordHasher>();
            services.AddTransient<IAuthHelper, AuthHelper>();

            #region Cookie Auth Service
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.Lax;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, o =>
                {
                    o.LoginPath = new PathString("/Account");
                    o.LogoutPath = new PathString("/Account");
                    o.AccessDeniedPath = new PathString("/AccessDenied");
                });

            #endregion

            #region policy & Authorize

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminArea", builder =>
                 builder.RequireRole(new List<string>
                 { Roles.Administration, Roles.ContentUploader }));

                options.AddPolicy("ShopAccess", builder =>
                 builder.RequireRole(new List<string> { Roles.Administration }));

                options.AddPolicy("DiscountAccess", builder =>
                 builder.RequireRole(new List<string> { Roles.Administration }));

                options.AddPolicy("AccountAccess", builder =>
                 builder.RequireRole(new List<string> { Roles.Administration }));

            });

            services.AddRazorPages().AddRazorPagesOptions(options =>
            {
                options.Conventions.AuthorizeAreaFolder("Administration", "/", "AdminArea");

                options.Conventions.AuthorizeAreaFolder("Administration", "/shop", "ShopAccess");

                options.Conventions.AuthorizeAreaFolder("Administration", "/discounts", "discountAccess");

                options.Conventions.AuthorizeAreaFolder("Administration", "/Accounts", "AccountAccess");

            }
            );

            #endregion


            #region html encoder

            services.AddSingleton<HtmlEncoder>(HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.BasicLatin, UnicodeRanges.Arabic
    }));

            #endregion
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );
            });
        }
    }
}
