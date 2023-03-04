using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    public class Course : Entity
    {
        public Therapy? Therapy { get; set; }
        public CourseSettings? CourseSettings { get; set; }
        public CourseType CourseType { get; set; }
        public List<DosingFrequency>? DosingFrequencies { get; set; }
        public List<Course> CourseGroup { get; set; }

        public TranslatedCourse TranslatedCourse { get; set; }
    }
}