using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    public class Therapy : Entity
    {
        public Guid UserId { get; set; }
        public List<Course>? Courses { get; set; }
        public TherapyStatus Status { get; set; }
        public TherapyType Type { get; set; }
        public TranslatedTherapy TranslatedTherapy { get; set; }
    }
}
