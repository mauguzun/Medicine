using Medicine.Entities.Models.Auth;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Base
{
    public abstract class EntityUser : Entity
    {
        public User? User { get; set; }

        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }
    }
}
