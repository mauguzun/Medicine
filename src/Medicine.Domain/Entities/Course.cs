using Medicine.Domain.Entities.Base;
using Medicine.Domain.Entities.Translated;
using Medicine.Domain.Enums;

namespace Medicine.Domain.Entities
{
    public class Course : Entity
    {
        public Therapy? Therapy { get; set; }
        public CourseSettings? CourseSettings { get; set; }
        public CourseType CourseType { get; set; }
        public List<DosingFrequency>? DosingFrequencies { get; set; }
        public List<Course> CourseGroup { get; set; }

        public List<TranslatedCourse> TranslatedCourse { get; set; } 
    }
}