using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    public class DrugCategory : Entity
    {
        public List<TransatedEntityWithDescription> TranslatedDrugsCategory { get; set; }
    }
}