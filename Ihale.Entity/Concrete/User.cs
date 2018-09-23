using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ihale.Core.Entity;
namespace Ihale.Entity.Concrete
{
    public class User : Entities
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public Gender Gender { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LastSeenDate { get; set; }
        public int RateCount { get; set; }
        public int Rate { get; set; }
        public virtual IEnumerable<UserComment> Comments { get; set; }
    }
}
