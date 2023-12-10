using Medicine.Entities.Models.Base.Interfaces;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models.Drugs
{
    /// <summary>
    /// Medicine,drugs
    /// </summary>
    public class Drug : TranslationEntity<TranslatedDrugs>
    {
        public string? Title { get; set; }
        public double OneUnitSizeInGramm { get; set; }

        public List<DrugCategory> DrugCategories { get; set; } = new();

        public SimilarDrugs SimilarDrugs { get; set; } = new();
        public int SimilarDrugsId { get; set; }

        public List<ActiveElement> ActiveElements { get; set; } = new();

    }
}
