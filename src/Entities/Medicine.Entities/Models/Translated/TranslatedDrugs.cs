using Medicine.Entities.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedDrugs))]
    public class TranslatedDrugs : TransatedEntityWithDescription
    {
        public Drug Drug { get; set; }
    }
}
