using Medicine.Domain.Entities.Base;

namespace Medicine.Domain.Entities
{
    public class DrugCategory : Entity
    {
        public List<TransatedEntityWithDescription> TranslatedDrugsCategory { get; set; }
    }
}