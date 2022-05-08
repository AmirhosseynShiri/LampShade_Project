using BlogMangement.Application.Contracts.AricleCategory;
using System.Collections.Generic;

namespace BlogMangement.Application.Contracts.Article
{
    public class ArticleSearchModel
    {
        public string Title { get; set; }
        public long CategoryId { get; set; }
        public List<ArticleCategoryViewModel> Categories { get; set; }
    }
}
