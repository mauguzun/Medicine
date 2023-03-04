using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models.Translated
{
    public class TranslatedCourse : TransatedEntityWithDescription
    {
        public string? Version { get; set; }
    }
}