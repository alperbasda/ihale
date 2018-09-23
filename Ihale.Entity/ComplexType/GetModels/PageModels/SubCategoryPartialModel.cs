using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class SubCategoryPartialModel : IViewModel
    {
        public IEnumerable<SubCategoryModel> SubCategoryModels { get; set; }
    }
}