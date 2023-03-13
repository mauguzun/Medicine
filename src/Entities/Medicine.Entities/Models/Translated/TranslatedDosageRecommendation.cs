using Medicine.Entities.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedDosageRecommendation))]
    public class TranslatedDosageRecommendation : TransatedEntityWithDescription
    {

        public DosageRecommendation DosageRecommendation { get; set; } 
    }
}
