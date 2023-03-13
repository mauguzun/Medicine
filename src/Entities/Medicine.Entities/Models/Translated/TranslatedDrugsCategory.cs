using Medicine.Entities.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedDrugsCategory))]
    public class TranslatedDrugsCategory : TransatedEntityWithDescription
    {
        public DrugCategory DrugCategory { get; set; }
    }

}
