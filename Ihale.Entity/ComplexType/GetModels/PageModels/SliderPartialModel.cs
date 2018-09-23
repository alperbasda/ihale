using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class SliderPartialModel : IViewModel
    {
        public IEnumerable<SliderModel> SliderModels { get; set; }
    }
}