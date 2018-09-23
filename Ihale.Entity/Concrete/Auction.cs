using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public class Auction : Entities
    {
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }
        public bool IsActive  { get; set; }
        public int Count { get; set; }
        public bool IsRetail { get; set; }

        [InverseProperty("Auction")]
        public virtual IEnumerable<CategoryFilterDescriptionAuctionRelation> CategoryInAuction { get; set; }
        
    }
}
