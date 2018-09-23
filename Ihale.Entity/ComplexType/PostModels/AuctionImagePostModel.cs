using System.Web;

namespace Ihale.Entity.ComplexType.PostModels
{
    public class AuctionImagePostModel : IViewModel
    {
        public int AuctionId { get; set; }

        public HttpPostedFileBase Image { get; set; }
    }
}