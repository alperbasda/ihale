using System.Collections.Generic;
using System.Linq;
using Ihale.Core.DataAccess.EntityFramework;
using Ihale.DataAccess.Abstract;
using Ihale.DataAccess.Concrete.EntityFramework.Core;
using Ihale.Entity.Concrete;

namespace Ihale.DataAccess.Concrete.EntityFramework
{
    public class UserDal : EfEntityRepositoryBase<User, IhaleContext>,IUserDal
    {
        public List<Role> GetUserRoles(int userId)
        {
            using (IhaleContext context = new IhaleContext())
            {
                return context.UserInRoles.Where(s => s.UserId == userId).Select(s => s.Role).ToList();
            }
        }

        public bool SetUserRole(int userId, int roleId)
        {
            using (IhaleContext context = new IhaleContext())
            {
                return context.UserInRoles.Add(new UserInRole { RoleId = roleId, UserId = userId })!=null;
            }
        }
    }
}