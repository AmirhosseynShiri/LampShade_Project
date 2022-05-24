using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public abstract class BaseRazorPageModel : PageModel
    {
        protected string SuccessMessage = "SuccessMessage";
        protected string ErrorMessage = "ErrorMessage";
        protected string InfoMessage = "InfoMessage";
        protected string WarningMessage = "WarningMessage";

    }
}
