﻿using _0_FrameWork.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogMangement.Application.Contracts.AricleCategory
{
    public interface IArticleCategoryApplication
    {
        OperationResult Create(CreateArticleCategory command);
        OperationResult Edit(EditArticleCategory command);
        EditArticleCategory GetDetails(long id);
        List<ArticleCategoryViewModel> GetArticleCategories();
        List<ArticleCategoryViewModel> Search(ArticleCategorySearchModel searchModel);
    }
}
