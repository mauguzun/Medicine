using Medicine.Entities.Models.Drugs;
using Medicine.Entities.Models.Translated.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedDrugsCategory))]
    public class TranslatedDrugsCategory : TransatedEntityWithDescription
    {
        public int DrugCategoryId { get; set; }
        public DrugCategory DrugCategory { get; set; } 
    }

}
