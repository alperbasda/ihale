using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class UserAuctionsModel : IViewModel
    {
        public IEnumerable<AuctionModel> AuctionModels { get; set; }
    }
}