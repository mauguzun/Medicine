using Medicine.Entities.Models.Translated.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedDosingFrequency))]
    public class TranslatedDosingFrequency : TransatedEntityWithDescription
    {
        public int DosingFrequencyId { get; set; }
        public DosingFrequency DosingFrequency { get; set; }

    }
}