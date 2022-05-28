using _0_FrameWork.Infrastructure;
using System.Collections.Generic;

namespace AccountManagement.Appllication.Contract.Role
{
    public class EditRole:CreateRole
    {
        public long Id { get; set; }
        public List<PermissionDto> MappedPermission { get; set; }
    }
}
