using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base.Interfaces;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models.Therapies
{
    /// <summary>
    /// Therapy can be assigned to user , or crate manualy 
    /// Each therapy can contain many courses
    /// </summary>
    public class Therapy : TranslationEntity<TranslatedTherapy>
    {
        public int UserId { get; set; }
        public TherapyStatus Status { get; set; } = TherapyStatus.None;
        public TherapyType Type { get; set; } = TherapyType.None;

        public List<Courses.Course> Courses { get; set; } = new List<Courses.Course>();

    }
}
