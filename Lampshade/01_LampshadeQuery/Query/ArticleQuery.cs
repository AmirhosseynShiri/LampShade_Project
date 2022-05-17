using _0_Framework.Application;
using _01_LampshadeQuery.Contract.Article;
using _01_LampshadeQuery.Contract.Comment;
using _01_LampshadeQuery.Contract.Product;
using BlogManagement.Infrastructure.EfCore;
using CommentManagement.Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_LampshadeQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;
        private readonly CommentContext _commentContext;

        public ArticleQuery(BlogContext context, CommentContext commentContext)
        {
            _context = context;
            _commentContext = commentContext;
        }

        public ArticleQueryModel GetArticleDetails(string slug)
        {
            var article= _context.Articles.Include(x => x.Category).Where(x => x.PublishDate <= DateTime.Now).Select(x => new ArticleQueryModel
            {
                Id=x.Id,
                CategoryId = x.CategoryId,
                Title = x.Title,
                PublishDate = x.PublishDate.ToFarsi(),
                CanonicalAddress = x.CanonicalAddress,
                Category = x.Category.Name,
                CategorySlug = x.Category.Slug,
                Description = x.Description,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription,
                Slug = x.Slug,
            }).SingleOrDefault(x=>x.Slug == slug);

            if (!string.IsNullOrWhiteSpace(article.Keywords))
                article.KeywordList = article.Keywords.Split(",").ToList();

            
                 var comments = _commentContext.Comments
                .Where(x => x.Type == CommentTypes.Article)
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
                .Where(x=>x.OwnerRecordId==article.Id)
                .Select(x => new CommentQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Message = x.Message,
                    Website = x.Website,
                    CreationDate = x.CreationDate.ToFarsi(),
                    ParentId=x.ParentId,
                }).OrderByDescending(x => x.Id).ToList();
            foreach (var comment in comments)
            {
                if(comment.ParentId>0)
                comment.ParentName=comments.FirstOrDefault(x=>x.Id==comment.ParentId).Name;
            }

            article.Comments = comments;
            return article;
        }

        public List<ArticleQueryModel> LatestArticles()
        {
            return _context.Articles.Include(x => x.Category).Where(x => x.PublishDate <= DateTime.Now).Select(x => new ArticleQueryModel
            {
                Title = x.Title,
                PublishDate = x.PublishDate.ToFarsi(),
                Category = x.Category.Name,
                CategorySlug = x.Category.Slug,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription,
                Slug=x.Slug
            }).ToList();
        }
    }
}
