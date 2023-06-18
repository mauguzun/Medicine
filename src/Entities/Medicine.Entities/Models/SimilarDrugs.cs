using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    public class SimilarDrugs : Entity
    {
        public List<Drug> SimilarDrugsList { get; set; } = new();
    }
}