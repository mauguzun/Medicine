using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using System.ComponentModel;

namespace Medicine.Entities.Models
{
    public class Drug : EntityByUser
    {
        public string? Recomendation { get; set; }
        public string? Title { get; set; }
        public double OneUnitSizeInGramm { get; set; }
        public ICollection<DrugCategory> DrugCategory { get; set; } 
        public ICollection<Drug> SimilarPreparate { get; set; }
        public ICollection<ActiveElement> ActiveElements { get; set; } 
        public ICollection<TranslatedDrugs> TranslatedDrugs { get; set; }

    }
}
