using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public class CategoryFilterDescriptionAuctionRelation : Entities
    {
        public int CategoryFilterDescriptionId { get; set; }

        [ForeignKey("CategoryFilterDescriptionId")]
        public virtual CategoryFilterDescription CategoryFilterDescription { get; set; }
        public int AuctionId { get; set; }

        [ForeignKey("AuctionId")]
        public virtual Auction Auction { get; set; }
    }
}
