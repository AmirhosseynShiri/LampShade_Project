﻿using _0_Framework.Application;
using _01_LampshadeQuery.Contract.Article;
using BlogManagement.Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_LampshadeQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;

        public ArticleQuery(BlogContext context)
        {
            _context = context;
        }

        public ArticleQueryModel GetArticleDetails(string slug)
        {
            var article= _context.Articles.Include(x => x.Category).Where(x => x.PublishDate <= DateTime.Now).Select(x => new ArticleQueryModel
            {
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