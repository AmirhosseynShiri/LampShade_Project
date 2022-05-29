using System.Collections.Generic;

namespace _0_FrameWork.Application
{
    public interface IAuthHelper
    {
        void SignIn(AuthViewModel account);
        void SignOut();
        bool IsAuthenticated();
        string CurrentAccountRole();
        AuthViewModel CurrentAccountInfo();
        List<int> GetPermissions();
    }
}
