using Medicine.Domain.Entities.Base;

namespace Medicine.Domain.Entities.Translated
{
    public class TranslatedCourse : TransatedEntityWithDescription
    {
        public string? Version { get; set; }

    }
}