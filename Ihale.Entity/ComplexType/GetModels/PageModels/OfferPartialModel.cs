using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class OfferPartialModel : IViewModel
    {
        public IEnumerable<OfferModel> OfferModels { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPage { get; set; }
    }
}