using System.ComponentModel.DataAnnotations;

namespace Ihale.Core.Entity
{
    public class Entities : IEntity
    {
        [Key]
        public int Id { get; set; }

        public bool IsDeleted { get; set; }
    }
}