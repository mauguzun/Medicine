using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    public class DrugCategory : EntityByUser
    {
        public List<TransatedEntityWithDescription> TranslatedDrugsCategory { get; set; }
    }
}