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
        public List<DrugCategory> DrugCategory { get; set; } = new List<DrugCategory>();
        public List<Drug> SimilarPreparate { get; set; } = new List<Drug>();
        public List<ActiveElement> ActiveElements { get; set; } = new List<ActiveElement>();
        public List<TranslatedDrugs> TranslatedDrugs { get; set; } = new List<TranslatedDrugs>();

    }
}
