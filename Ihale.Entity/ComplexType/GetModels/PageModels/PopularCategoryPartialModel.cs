using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class PopularCategoryPartialModel : IViewModel
    {
        public IEnumerable<PopularCategoryModel> PopularCategoryModels { get; set; }
    }
}