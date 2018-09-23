using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ihale.Core.DataAccess.EntityFramework;
using Ihale.DataAccess.Abstract;
using Ihale.DataAccess.Concrete.EntityFramework.Core;
using Ihale.Entity.Concrete;

namespace Ihale.DataAccess.Concrete.EntityFramework
{
    public class UserCommentDal : EfEntityRepositoryBase<UserComment, IhaleContext>, IUserCommentDal
    {
    }
}
