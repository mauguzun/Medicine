using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    public class Therapy : EntityByUser
    {
        public Guid UserId { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public TherapyStatus Status { get; set; } = TherapyStatus.None;
        public TherapyType Type { get; set; } = TherapyType.None;
        public List<TranslatedTherapy> TranslatedTherapies { get; set; } = new List<TranslatedTherapy>();
    }
}
