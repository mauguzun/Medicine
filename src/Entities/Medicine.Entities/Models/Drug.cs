using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using System.ComponentModel;

namespace Medicine.Entities.Models
{
    public class Drug : Entity
    {
        public string? Recomendation { get; set; }
        public double OneItemWeight { get; set; }
        public List<DrugCategory> DrugCategory { get; set; }
        public List<Drug> SimilarPreparate { get; set; }
        public List<ActiveElement> ActiveElements { get; set; }
        public TranslatedDrugs TranslatedDrugs { get; set; }
    }
}
