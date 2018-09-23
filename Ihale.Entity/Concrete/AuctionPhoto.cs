using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public class AuctionPhoto : Entities
    {
        public int AuctionId { get; set; }

        [ForeignKey("AuctionId")]
        public virtual Auction Auction { get; set; }

        public string PhotoPath { get; set; }
    }
}
