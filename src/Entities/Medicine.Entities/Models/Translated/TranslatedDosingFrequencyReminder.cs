using Medicine.Entities.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedDosingFrequencyReminder))]
    public class TranslatedDosingFrequencyReminder : TransatedEntityWithDescription
    {
        public DosingFrequencyReminder DosageRecommendation { get; set; } 
    }
}
