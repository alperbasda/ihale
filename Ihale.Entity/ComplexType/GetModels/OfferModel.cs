using System;

namespace Ihale.Entity.ComplexType.GetModels
{
    public class OfferModel : IViewModel
    {
        public int AuctionId { get; set; }

        public int OfferId { get; set; }

        public string AuctionName { get; set; }

        public string OfferPrice { get; set; }

        public bool OfferAccepted { get; set; }

        public DateTime OfferDate { get; set; }

        public string OfferDescription { get; set; }
    }
}