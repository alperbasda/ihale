using System.Collections.Generic;
using Ihale.Core.DataAccess;
using Ihale.Entity.Concrete;

namespace Ihale.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepositoryBase<User>
    {
        List<Role> GetUserRoles(int userId);
        bool SetUserRole(int userId,int roleId);
    }
}