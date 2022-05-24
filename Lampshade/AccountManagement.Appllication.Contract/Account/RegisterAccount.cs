using _0_FrameWork.Application;
using AccountManagement.Appllication.Contract.Role;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Appllication.Contract.Account
{
    public class RegisterAccount
    {
        [Required(ErrorMessage =ValidationMessages.IsRequired)]
        public string FullName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string UserName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Password { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Mobile { get; set; }

        public long RoleId { get; set; }
        public IFormFile ProfilePhoto { get; set; }
        public List<RoleViewModel> Roles { get; set; }
    }
}
