using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class AboutUsModel : IViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public IEnumerable<TeamModel> TeamModels { get; set; }
    }
}