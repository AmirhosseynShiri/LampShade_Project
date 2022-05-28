using _0_FrameWork.Infrastructure;
using System.Collections.Generic;

namespace AccountManagement.Appllication.Contract.Role
{
    public class CreateRole
    {
        public string Name { get; set; }
        public List<int> Permissions { get; set; }
    }
}
