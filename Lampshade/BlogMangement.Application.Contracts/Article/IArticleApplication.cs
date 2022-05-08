using _0_FrameWork.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogMangement.Application.Contracts.Article
{
    public interface IArticleApplication
    {
        OperationResult Create(CreateArticle command);
        OperationResult Edit (EditArticle command);
        EditArticle GetDatails(long id);
        List<ArticleViewModel> Search(ArticleSearchModel searchModel);

    }
}
