using System.ComponentModel.DataAnnotations;

namespace Medicine.Entities.Models.Base
{
    public class EntityByUser : Entity
    {
        public int CreatedBy { get; set; }
    }

    public class Entity
    {

        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
