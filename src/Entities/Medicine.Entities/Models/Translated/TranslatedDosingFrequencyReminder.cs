using Medicine.Entities.Models.Translated.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedDosingFrequencyReminder))]
    public class TranslatedDosingFrequencyReminder : TransatedEntity
    {
        public string Title { get; set; }
        public string UsingDescription { get; set; }
        public DosingFrequencyReminder DosageRecommendation { get; set; }
    }
}
