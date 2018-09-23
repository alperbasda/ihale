using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class TelephonePartialModel : IViewModel
    {
        public IEnumerable<TelephoneModel> TelephoneModels { get; set; }
    }
}