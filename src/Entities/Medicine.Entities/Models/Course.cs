using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    public class Course : TranslationEntity<TranslatedCourse>
    {
        public int TherapyId { get; set; }
        public Therapy Therapy { get; set; }
        public CourseGroup? CourseGroup { get; set; }
        public int? CourseGroupID { get; set; }
        public CourseType CourseType { get; set; } = CourseType.None;
        public List<CourseSettings> CourseSettings { get; set; } = new List<CourseSettings>();
        public List<DosingFrequency> DosingFrequencies { get; set; } = new List<DosingFrequency>();
    }
}