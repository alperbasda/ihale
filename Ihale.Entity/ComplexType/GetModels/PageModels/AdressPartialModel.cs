using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class AdressPartialModel : IViewModel
    {
        public IEnumerable<AdressModel> AdressModels { get; set; }
    }
}