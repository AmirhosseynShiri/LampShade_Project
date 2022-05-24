using AccountManagement.Appllication.Contract.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class AccountModel : PageModel
    {
        protected string SuccessMessage = "SuccessMessage";
        protected string ErrorMessage = "ErrorMessage";
        private readonly IAccountApplication _accountApplication;

        public AccountModel(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostLogin(Login command)
        {
            var result = _accountApplication.Login(command);
            if (result.IsSuccedded)
            {
                TempData[SuccessMessage] = "ورود شما با موفقیت انجام شد";
                return RedirectToPage("./Index");
            }

            TempData[ErrorMessage] = "ورود شما با شکست مواجه شد";
            return RedirectToPage("./Account");
        }

        public IActionResult OnGetLogout()
        {
            _accountApplication.Logout();
            return RedirectToPage("/Index");
        }

        public IActionResult OnPostRegister(RegisterAccount command)
        {
           var resulr= _accountApplication.Register(command);
            return RedirectToPage("/Account");
        }
    }
}
