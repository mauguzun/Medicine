using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    public class Course : EntityByUser
    {
        public Therapy? Therapy { get; set; }
        public CourseSettings? CourseSettings { get; set; }
        public CourseType CourseType { get; set; } = CourseType.None;

        public List<DosingFrequency> DosingFrequencies { get; set; } = new List<DosingFrequency>();
        public List<Course> CourseGroup { get; set; } = new List<Course>(); 
        public List<TranslatedCourse> TranslatedCourses { get; set; } = new List<TranslatedCourse>();
    }
}