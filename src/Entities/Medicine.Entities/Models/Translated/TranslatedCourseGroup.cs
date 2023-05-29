using Medicine.Entities.Models.Translated.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedCourseGroup))]
    public class TranslatedCourseGroup : TransatedEntityWithDescription
    {
        public CourseGroup CourseGroup { get; set; }

    }
}