using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public class Category : Entities
    {
        public string Name { get; set; }

        public int? UpCategoryId { get; set; }

        public string CategoryImageBig { get; set; }

        public string CategoryImageSmall { get; set; }

        public string Description { get; set; }

        [ForeignKey("UpCategoryId")]
        public Category UpCategory { get; set; }

        [InverseProperty("Category")]
        public virtual IEnumerable<CategoryFilterRelation> FilterInCategory { get; set; }
    }
}
