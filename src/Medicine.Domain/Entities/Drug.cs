using Medicine.Domain.Entities.Base;
using Medicine.Domain.Entities.Translated;
using System.ComponentModel;

namespace Medicine.Domain.Entities
{
    public class Drug : Entity
    {
        public string? Recomendation { get; set; }
        public double OneItemWeight { get; set; }
        public List<DrugCategory> DrugCategory { get; set; }
        public List<Drug> Analog { get; set; }
        public Dictionary<double, string>? ActiveElements { get; set; }

        public List<TranslatedDrugs> TranslatedDrugs { get; set; }
    }
}
