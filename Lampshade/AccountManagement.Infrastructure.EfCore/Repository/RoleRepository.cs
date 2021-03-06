using _0_Framework.Application;
using _0_FrameWork.Infrastructure;
using AccountManagement.Appllication.Contract.Role;
using AccountManagement.Domain.RoleAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Infrastructure.EfCore.Repository
{
    public class RoleRepository : RepositoryBase<long, Role>, IRoleRepository
    {
        private readonly AccountContext _accountContext;

        public RoleRepository(AccountContext accountContext):base(accountContext)
        {
            _accountContext = accountContext;
        }

        public EditRole GetDetails(long id)
        {
            return _accountContext.Roles.Select(x=>new EditRole
            {
                Id = x.Id,
                Name = x.Name,
                MappedPermission=MapPermissions(x.Permissions)
            }).AsNoTracking().FirstOrDefault(x=>x.Id==id);
        }

        private static List<PermissionDto> MapPermissions(IEnumerable<Permission> permissions)
        {
            return permissions.Select(x => new PermissionDto (x.Code,x.Name)).ToList();
        }

        public List<RoleViewModel> List()
        {
            return _accountContext.Roles.Select(x => new RoleViewModel
            {
                Id = x.Id,
                Name = x.Name,
                CreationDate=x.CreationDate.ToFarsi()
            }).ToList();
        }
    }
}
