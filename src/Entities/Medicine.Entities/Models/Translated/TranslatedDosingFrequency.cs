using Medicine.Entities.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedDosingFrequency))]
    public class TranslatedDosingFrequency : TransatedEntityWithDescription
    {
        public DosingFrequency DosingFrequency { get; set; }

    }
}