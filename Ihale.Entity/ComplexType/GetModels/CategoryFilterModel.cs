using System.Collections.Generic;
using Ihale.Entity.Concrete;

namespace Ihale.Entity.ComplexType.GetModels
{
    public class CategoryFilterModel : IViewModel
    {
        public int FilterId { get; set; }

        public string FilterName { get; set; }

        public IEnumerable<CategoryFilterDescription> CategoryFilterDescriptions { get; set; }

    }
}