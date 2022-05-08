using _0_FrameWork.Domain;
using BlogMangement.Application.Contracts.Article;
using System.Collections.Generic;

namespace BlogManagement.Domain.ArticleAgg
{
    public interface IArticleRepository:IRepository<long,Article>
    {
        EditArticle GetDetails(long id);
        Article GetWithCategory(long id);
        List<ArticleViewModel> Search(ArticleSearchModel searchModel);
    }
}
