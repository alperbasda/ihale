using System.Data.Entity;
using Ihale.Business.Abstract;
using Ihale.Business.Concrete.Managers;
using Ihale.DataAccess.Abstract;
using Ihale.DataAccess.Concrete.EntityFramework;
using Ihale.DataAccess.Concrete.EntityFramework.Core;
using Ninject.Modules;

namespace Ihale.Business.DepandencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<ICategoryCategoryPropertyRelationDal>().To<CategoryCategoryPropertyRelationDal>();
            Bind<ICategoryDal>().To<CategoryDal>();
            //Bind<ICategoryPropertyDal>().To<CategoryPropertyDal>();
            //Bind<IExpiredProductDal>().To<ExpiredProductDal>();
            //Bind<IOfferDal>().To<OfferDal>();
            //Bind<IOfferImageDal>().To<OfferImageDal>();
            //Bind<IProductCategoryPropertyRelationDal>().To<ProductCategoryPropertyRelationDal>();
            //Bind<IProductDal>().To<ProductDal>();
            //Bind<IUserDal>().To<UserDal>();
            //Bind<IRoleDal>().To<RoleDal>();
            //Bind<IUserInRoleDal>().To<UserInRoleDal>();
            //Bind<IUserPaidProductDal>().To<UserPaidProductDal>();


            //Bind<ICategoryCategoryPropertyRelationService>().To<CategoryCategoryPropertyRelationManager>();
            //Bind<ICategoryPropertyService>().To<CategoryPropertyManager>();
            Bind<ICategoryService>().To<CategoryManager>();
            //Bind<IExpiredProductService>().To<ExpiredProductManager>();
            //Bind<IOfferImageService>().To<OfferImageManager>();
            //Bind<IOfferService>().To<OfferManager>();
            //Bind<IProductCategoryPropertyRelationService>().To<ProductCategoryPropertyRelationManager>();
            //Bind<IProductService>().To<ProductManager>();
            //Bind<IRoleService>().To<RoleManager>();
            //Bind<IUserInRoleService>().To<UserInRoleManager>();
            //Bind<IUserPaidProductService>().To<UserPaidProductManager>();
            //Bind<IUserService>().To<UserManager>();

            Bind<DbContext>().To<IhaleContext>();
        }
    }
}