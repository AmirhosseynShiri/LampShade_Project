using _0_Framework.Application;
using _0_FrameWork.Infrastructure;
using BlogManagement.Domain.ArticleAgg;
using BlogMangement.Application.Contracts.Article;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogManagement.Infrastructure.EfCore.Repository
{
    public class ArticleRepository : RepositoryBase<long, Article>, IArticleRepository
    {
        private readonly BlogContext _context;

        public ArticleRepository(BlogContext context):base(context)
        {
            _context = context;
        }

        public EditArticle GetDetails(long id)
        {
            return _context.Articles.Select(x=>new EditArticle
            {
                Id=x.Id,
                CanonicalAddress=x.CanonicalAddress,
                Description=x.Description,
                Keywords=x.Keywords,
                MetaDescription=x.MetaDescription,
                PictureAlt = x.PictureAlt,
                PictureTitle=x.PictureTitle,
                PublishDate=x.PublishDate.ToFarsi(),
                ShortDescription=x.ShortDescription,
                Slug=x.Slug,
                Title=x.Title
            }).SingleOrDefault(x => x.Id == id);
        }

        public Article GetWithCategory(long id)
        {
            return _context.Articles.Include(x=>x.Category).SingleOrDefault(x => x.Id == id);
        }

        public List<ArticleViewModel> Search(ArticleSearchModel searchModel)
        {
            var query = _context.Articles.Select(x => new ArticleViewModel
            {
                Id=x.Id,
                Title=x.Title,
                Category=x.Category.Name,
                Picture=x.Picture,
                PublishDate=x.PublishDate.ToFarsi(),
                ShortDescription=x.ShortDescription.Substring(0, Math.Min(x.ShortDescription.Length, 50)) +"...",
                CategoryId=x.CategoryId,
            });

            if(!string.IsNullOrWhiteSpace( searchModel.Title))
                query=query.Where(x=>x.Title.Contains(searchModel.Title));

            if (searchModel.CategoryId > 0)
                query = query.Where(x => x.CategoryId == searchModel.CategoryId);

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
