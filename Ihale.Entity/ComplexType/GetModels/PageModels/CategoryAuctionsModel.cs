using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class CategoryAuctionsModel : IViewModel
    {
        public IEnumerable<AuctionModel> Auctions { get; set; }

        public int TotalPage { get; set; }

        public int CurrentPage { get; set; }
    }
}