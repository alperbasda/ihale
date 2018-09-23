using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class CategoryBaseModel : IViewModel
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryBigImageUrl { get; set; }

        public string CategoryDescription { get; set; }

        public IEnumerable<SubCategoryModel> SubCategoryModels { get; set; }

        public IEnumerable<CategoryFilterModel> CategoryFilterModels { get; set; }
    }
}