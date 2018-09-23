using System;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class UserInformationModel : IViewModel
    {
        public DateTime RegisterDate { get; set; }

        public DateTime LastSeenDate { get; set; }

        public int Rate { get; set; }

        public int RateCount { get; set; }

        public int AuctionCount { get; set; }

        public int OfferCount { get; set; }

        public int AcceptedOfferCount { get; set; }

        public UserCommentModel UserCommentModel { get; set; }
    }
}