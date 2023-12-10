using Medicine.Entities.Models.Courses;
using Medicine.Entities.Models.Translated.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedCourse))]
    public class TranslatedCourse : TransatedEntityWithDescription
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string? Version { get; set; }
    }
}