using Medicine.Entities.Models.Auth;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Base
{
    public abstract class EntityUser : Entity
    {
        public User? CreatedBy { get; set; }

        [ForeignKey(nameof(CreatedBy))]
        public int? CreatedById { get; set; }
    }
}
