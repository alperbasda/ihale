using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class BlogModel : IViewModel
    {
        public int CurrentPage { get; set; }

        public int TotalPage { get; set; }

        public IEnumerable<BlogShowModel> BlogShowModels { get; set; }
    }
}