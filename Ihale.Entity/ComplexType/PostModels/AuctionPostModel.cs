using System;
using System.Collections.Generic;

namespace Ihale.Entity.ComplexType.PostModels
{
    public class AuctionPostModel : IViewModel
    {
        public int CategoryId { get; set; }

        public string AuctionName { get; set; }

        public decimal UpperBound { get; set; }

        public decimal LowerBound { get; set; }

        public DateTime AuctionLastDate { get; set; }

        public IEnumerable<AuctionImagePostModel> AuctionImagePostModels { get; set; }


    }
}