using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public class CategoryFilterRelation : Entities
    {
        public int CategoryFilterId { get; set; }

        [ForeignKey("CategoryFilterId")]
        public virtual CategoryFilter CategoryFilter { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
