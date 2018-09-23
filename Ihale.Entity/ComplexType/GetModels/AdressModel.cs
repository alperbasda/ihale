using Ihale.Entity.Concrete;

namespace Ihale.Entity.ComplexType.GetModels
{
    public class AdressModel : IViewModel
    {
        public int AddressId { get; set; }

        public string Address { get; set; }

        public AdressType AdressType { get; set; }

    }
}