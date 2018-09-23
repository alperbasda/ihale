using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public class Blog : Entities
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public int RateCount { get; set; }
        public int Rate { get; set; }
        public virtual IEnumerable<BlogComment> Comments { get; set; }
    }
}
