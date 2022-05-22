using CommentManagement.Application.Contract.Comment;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Comments
{
    public class IndexModel : AdminBaseRazorPageModel
    {
        public List<CommentViewModel> Comments;
        public CommentSearchModel SearchModel;

        private readonly ICommentApplication _commentApplication;

        public IndexModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }

        public void OnGet(CommentSearchModel searchModel)
        {
            Comments = _commentApplication.Search(searchModel);
        }



        public IActionResult OnGetConfirm(long id)
        {
            var result = _commentApplication.Confirm(id);
            if (result.IsSuccedded)
            {

                TempData[SuccessMessage] = "کامنت مورد نظر تایید شد!";
                return RedirectToPage("./Index");
            }

            TempData[ErrorMessage] = "عملیات تایید کامنت با شکست مواجه شد!";
            return RedirectToPage("./Index");

        }

        public IActionResult OnGetCancel(long id)
        {
            var result = _commentApplication.Cancel(id);
            if (result.IsSuccedded)
            {

                TempData[SuccessMessage] = "کامنت مورد نظر کنسل شد!";
                return RedirectToPage("./Index");
            }

            TempData[ErrorMessage] = "عملیات کنسل کامنت با شکست مواجه شد!";
            return RedirectToPage("./Index");
        }
    }
}
