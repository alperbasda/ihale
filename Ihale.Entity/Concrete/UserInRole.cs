using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public class UserInRole : Entities
    {

        public int UserId { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}