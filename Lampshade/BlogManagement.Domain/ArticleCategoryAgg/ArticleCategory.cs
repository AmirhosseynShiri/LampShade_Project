﻿using _0_FrameWork.Domain;
using BlogManagement.Domain.ArticleAgg;
using System.Collections.Generic;

namespace BlogManagement.Domain.ArticleCategoryAgg
{
    public class ArticleCategory : EntityBase
    {
        public string Name { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Desription { get; private set; }
        public int ShowOrder { get; private set; }
        public string Slug { get; private set; }
        public string KeyWords { get; private set; }
        public string MetaDescription { get; private set; }
        public string CanonicalAddress { get; private set; }
        public List<Article> Articles { get; private set; }

        public ArticleCategory(string name, string picture, string pictureAlt, string pictureTitle, string desription,
            int showOrder, string slug, string keyWords, string metaDescription,
            string canonicalAddress)
        {
            Name = name;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Desription = desription;
            ShowOrder = showOrder;
            Slug = slug;
            KeyWords = keyWords;
            MetaDescription = metaDescription;
            CanonicalAddress = canonicalAddress;
        }

        public void Edit(string name, string picture, string pictureAlt, string pictureTitle, string desription,
            int showOrder, string slug, string keyWords, string metaDescription,
            string canonicalAddress)
        {
            Name = name;

            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;

            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Desription = desription;
            ShowOrder = showOrder;
            Slug = slug;
            KeyWords = keyWords;
            MetaDescription = metaDescription;
            CanonicalAddress = canonicalAddress;
        }
    }
}