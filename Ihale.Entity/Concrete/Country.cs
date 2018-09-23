
using System.Collections.Generic;
using Ihale.Core.Entity;

namespace Ihale.Entity.Concrete
{
    public class Country : Entities
    {
        public string Name { get; set; }

        public virtual IEnumerable<City> CitiesInCountry { get; set; }
    }
}