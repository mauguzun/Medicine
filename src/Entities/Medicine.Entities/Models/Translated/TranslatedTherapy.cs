using Medicine.Entities.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedTherapy))]
    public class TranslatedTherapy : TransatedEntityWithDescription
    {
        public Therapy Therapy { get; set; }
    }

}
