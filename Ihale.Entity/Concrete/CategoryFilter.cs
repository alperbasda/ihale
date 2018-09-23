using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public class CategoryFilter : Entities
    {
        public string FilterName { get; set; }

        [InverseProperty("CategoryFilter")]
        public virtual IEnumerable<CategoryFilterRelation> ContainsCategory { get; set; }
    }
}
