using Medicine.Entities.Models.Translated.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedCourse))]
    public class TranslatedCourse : TransatedEntityWithDescription
    {
        public Course Course { get; set; }
        public string? Version { get; set; }
    }
}