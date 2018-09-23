using System;

namespace Ihale.Entity.ComplexType.GetModels.PageModels
{
    public class OfferDetailModel : IViewModel
    {
        public int AuctionId { get; set; }

        public int OfferId { get; set; }

        public string AuctionName { get; set; }

        public AuctionCategoryPropertyDescriptionModel AuctionCategoryPropertyDescriptionModel { get; set; }

        public decimal OfferPrice { get; set; }

        public string OfferDescription { get; set; }

        public DateTime AuctionDate { get; set; }

        public DateTime OfferAcceptedDate { get; set; }

        public DateTime OfferDate { get; set; }

        public UserOfferContactModel UserOfferContactModel { get; set; }

    }
}