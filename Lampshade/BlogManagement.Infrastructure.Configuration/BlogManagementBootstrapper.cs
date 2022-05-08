using BlogManagement.Application;
using BlogManagement.Domain.ArticleAgg;
using BlogManagement.Domain.ArticleCategoryAgg;
using BlogManagement.Infrastructure.EfCore;
using BlogManagement.Infrastructure.EfCore.Repository;
using BlogMangement.Application.Contracts.AricleCategory;
using BlogMangement.Application.Contracts.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BlogManagement.Infrastructure.Configuration
{
    public class BlogManagementBootstrapper
    {
        public static void Configure(IServiceCollection services,string connectionString)
        {
            services.AddTransient<IArticleCategoryApplication,ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository,ArticleCategoryRepository>();

            services.AddTransient<IArticleApplication, ArticleApplication>();
            services.AddTransient<IArticleRepository, ArticleRepository>();

            services.AddDbContext<BlogContext>(x=>x.UseSqlServer(connectionString));
        }
    }
}
