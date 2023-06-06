using Medicine.Entities.Models.Base.Interfaces;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    /// <summary>
    /// Medicine,drugs
    /// </summary>
    public class Drug :  TranslationEntity<TranslatedDrugs>
    {

        public string? Title { get; set; }
        public double OneUnitSizeInGramm { get; set; }

        public List<DrugCategory> DrugCategories { get; set; }  = new List<DrugCategory>(); 
        //public List<Drug> SimilarPreparate { get; set; } = new List<Drug>();
        public List<ActiveElement> ActiveElements { get; set; } = new List<ActiveElement>(); 

    }
}
