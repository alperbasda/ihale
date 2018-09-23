using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public class UserTel : Entities
    {
        
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int TelephoneNumber { get; set; }
        public bool Approved { get; set; }
        public bool Using { get; set; }
        public DateTime UpdateDate { get; set; }


    }
}
