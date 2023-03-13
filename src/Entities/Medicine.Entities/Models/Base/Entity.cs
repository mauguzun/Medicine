using System.ComponentModel.DataAnnotations;

namespace Medicine.Entities.Models.Base
{
    public abstract class Entity 
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
