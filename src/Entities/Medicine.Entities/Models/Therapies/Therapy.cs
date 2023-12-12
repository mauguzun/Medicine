using Medicine.Entities.Enums;
using Medicine.Entities.Models.Auth;
using Medicine.Entities.Models.Base.Interfaces;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models.Therapies
{
    /// <summary>
    /// Therapy group of coureses , can be create by user 
    /// Can be create by doctor and assign to user
    /// </summary>
    
    public class Therapy : TranslationEntity<TranslatedTherapy>
    {
        public User? AssingedTo { get; set; }
        public int? AssingedToId { get; set; }

        public TherapyStatus Status { get; set; } = TherapyStatus.None;
        public TherapyType Type { get; set; } = TherapyType.None;
        public List<Courses.Course> Courses { get; set; } = new List<Courses.Course>();

    }
}
