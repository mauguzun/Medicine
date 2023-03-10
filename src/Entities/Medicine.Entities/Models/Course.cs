using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    public class Course : EntityByUser
    {
        public Therapy? Therapy { get; set; }
        public List<CourseSettings> CourseSettings { get; set; }
        public CourseType CourseType { get; set; } = CourseType.None;

        public ICollection<DosingFrequency> DosingFrequencies { get; set; }
        public ICollection<Course> CourseGroup { get; set; } 
        public ICollection<TranslatedCourse> TranslatedCourses { get; set; }
    }
}