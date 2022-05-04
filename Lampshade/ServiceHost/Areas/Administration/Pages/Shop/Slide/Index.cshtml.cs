using Microsoft.AspNetCore.Mvc;
using ShopManagement.Application.Contracts.Slide;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Shop.Slide
{
    public class IndexModel : AdminBaseRazorPageModel
    {
        public List<SlideViewModel> Slides;

        private readonly ISlideApplication _slideApplication;

        public IndexModel(ISlideApplication slideApplication)
        {
            _slideApplication = slideApplication;
        }

        public void OnGet()
        {
            Slides = _slideApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateSlide();

            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateSlide command)
        {
            var result = _slideApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var Slide = _slideApplication.GetDetails(id);
            return Partial("Edit", Slide);
        }

        public JsonResult OnPostEdit(EditSlide command)
        {
            var result = _slideApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
            var result = _slideApplication.Remove(id);
            if (result.IsSuccedded)
            {
                
                TempData[SuccessMessage] = "محصول مورد نظر در انبار خالی شد!";
                return RedirectToPage("./Index");
            }
            
            TempData[ErrorMessage] = "عملیات عدم موجودی محصول با شکست مواجه شد!";
            return RedirectToPage("./Index");

        }

        public IActionResult OnGetRestore(long id)
        {
            var result = _slideApplication.Restore(id);

            if (result.IsSuccedded)
            {
                TempData[WarningMessage] = "محصول مورد نظر در انبار موجود شد!";
                return RedirectToPage("./Index");
            }
            TempData[ErrorMessage] = "عملیات شارژ محصول با شکست مواجه شد!";
            return RedirectToPage("./Index");
        }
    }
}
