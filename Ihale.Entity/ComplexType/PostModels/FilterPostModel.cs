using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.PostModels
{
    public class FilterPostModel : IViewModel
    {
        public int CategoryId { get; set; }

        public List<int> SubCategoryIds { get; set; }

        public List<int> CategoryFilterDescriptionsIds { get; set; }

        public int CurrentPage { get; set; }
    }
}