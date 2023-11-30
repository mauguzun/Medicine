using Medicine.Entities.Models.Auth;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Base
{
    public abstract class EntityAuthor : Entity
    {
        public User? Author { get; set; }

        [ForeignKey(nameof(Author))]
        public int? AuthorId { get; set; }
    }
}
