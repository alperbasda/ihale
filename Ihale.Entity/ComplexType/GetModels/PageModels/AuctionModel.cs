using System;
using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.GetModels
{
    public class AuctionModel
    {
        public int CategoryId { get; set; }

        public int AuctionId { get; set; }

        public string CategoryName { get; set; }

        public string AuctionName { get; set; }

        public decimal UpperBound { get; set; }

        public decimal LowerBound { get; set; }

        public bool PaidAuction { get; set; }

        public DateTime AuctionLastDate { get; set; }

        public string ImagePath { get; set; }

        public IEnumerable<AuctionCategoryPropertyDescriptionModel> AuctionCategoryPropertyDescriptionModels { get; set; }


    }
}