using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models.Translated.Base;

namespace Medicine.Entities.Models
{
    public class CourseGroup : TransatedEntityWithDescription
    {
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<TranslatedCourseGroup> Translations { get; set; } = new List<TranslatedCourseGroup>();
    }
}