namespace Ihale.Entity.ComplexType.GetModels
{
    public class PopularCategoryModel : IViewModel
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryBigImageUrl { get; set; }
    }
}