using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class AuctionDetailModel : IViewModel
    {
        public AuctionModel AuctionModel { get; set; }

        public UserCommentModel UserCommentModel { get; set; }

        public string AuctionDescription { get; set; }

        public IEnumerable<AuctionImageModel> AuctionImageModels { get; set; }

    }
}