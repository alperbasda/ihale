using System;
using System.ComponentModel.DataAnnotations.Schema;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public class UserComment : Entities
    {
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public DateTime Date { get; set; }

        public string Comment { get; set; }

        public int Rate { get; set; }

        public string IsAccepted { get; set; }
    }
}