using System.ComponentModel.DataAnnotations;

namespace Medicine.Entities.Models.Base
{
    public abstract class Entity : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTimeOffset? CreatedAt { get; set; } = DateTimeOffset.Now;

    }
}
