﻿using Ihale.Core.DataAccess.EntityFramework;
using Ihale.DataAccess.Abstract;
using Ihale.DataAccess.Concrete.EntityFramework.Core;
using Ihale.Entity.Concrete;

namespace Ihale.DataAccess.Concrete.EntityFramework
{
    public class CategoryCategoryPropertyRelationDal : EfEntityRepositoryBase<CategoryCategoryPropertyRelation,IhaleContext>, ICategoryCategoryPropertyRelationDal
    {
    }
}