﻿using _0_FrameWork.Application;
using System.Collections.Generic;

namespace ShopManagement.Application.Contracts.Comment
{
    public interface ICommentApplication
    {
        OperationResult Add(AddComment command);
        OperationResult Confirm(long id);
        OperationResult Cancel (long id);
        List<CommentViewModel> Search(CommentSearchModel searchModel);
    }
}
