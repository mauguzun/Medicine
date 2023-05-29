using Medicine.Entities.Models.Translated.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedDrugs))]
    public class TranslatedDrugs : TransatedEntityWithDescription
    {
        public string? Recomendation { get; set; }
        public Drug Drug { get; set; }
    }
}
