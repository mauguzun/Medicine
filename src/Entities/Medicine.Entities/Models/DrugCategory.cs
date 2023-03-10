using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    public class DrugCategory : EntityByUser
    {
        public ICollection<Drug> Drugs { get; set; }
        public int DrugId { get; set; }
        public ICollection<TranslatedDrugsCategory> TranslatedDrugsCategory { get; set; }
    }
}