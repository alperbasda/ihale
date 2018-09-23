using System.Configuration;
using System.ServiceModel;

namespace Ihale.Core.Utilities.Common
{
    public class WcfProxy<T>
    {
        public static T CreateChannel()
        {
            string baseAdress = ConfigurationManager.AppSettings["ServiceAdress"];
            string address = string.Format(baseAdress, typeof(T).Name.Substring(1));
            var binding = new BasicHttpBinding();
            var channel = new ChannelFactory<T>(binding,address);
            return channel.CreateChannel();
        }
    }
}