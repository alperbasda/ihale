using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public class OfferPhoto : Entities
    {
        public int OfferId { get; set; }

        [ForeignKey("OfferId")]
        public virtual Offer Offer { get; set; }
        public string PhotoPath { get; set; }
    }
}
