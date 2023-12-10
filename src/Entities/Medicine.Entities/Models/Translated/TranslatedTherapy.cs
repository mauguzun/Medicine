using Medicine.Entities.Models.Therapies;
using Medicine.Entities.Models.Translated.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedTherapy))]
    public class TranslatedTherapy : TransatedEntityWithDescription
    {
        public int TherapyId { get; set; }
        public Therapy Therapy { get; set; }
    }

}
