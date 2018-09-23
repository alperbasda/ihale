using System.Threading.Tasks;
using Ninject;

namespace Ihale.Business.DepandencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule(),new AutoMapperModule());
            return kernel.Get<T>();
        }
    }
}