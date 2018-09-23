using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public enum AdressType
    {
        Fatura,
        Kargo
    }

    public class UserAdress : Entities
    {
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public AdressType AdressType { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
