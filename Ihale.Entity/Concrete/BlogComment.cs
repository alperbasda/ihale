using System;
using System.ComponentModel.DataAnnotations.Schema;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public class BlogComment : Entities
    {
        public int BlogId { get; set; }

        [ForeignKey("BlogId")]
        public Blog Blog { get; set; }

        public DateTime Date { get; set; }

        public string Comment { get; set; }

        public int Rate { get; set; }

        public string IsAccepted { get; set; }
    }
}