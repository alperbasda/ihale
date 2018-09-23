using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public class CategoryFilterDescription : Entities
    {
        public int CategoryFilterId { get; set; }

        [ForeignKey("CategoryFilterId")]
        public virtual CategoryFilter CategoryFilter { get; set; }
        public string Description { get; set; }

        [InverseProperty("CategoryFilterDescription")]
        public virtual IEnumerable<CategoryFilterDescriptionAuctionRelation> FilterInAuction { get; set; }

    }
}
