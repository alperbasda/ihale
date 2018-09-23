using Ihale.Business.Abstract;
using Ihale.Core.Utilities.Common;
using Ninject.Modules;

namespace Ihale.Business.DepandencyResolvers.Ninject
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryService>().ToConstant(WcfProxy<ICategoryService>.CreateChannel());
        }
    }
}