using Medicine.Entities.Models.Base.Interfaces;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models.Drugs
{
    /// <summary>
    /// Drug category , can containt many drugs
    /// </summary>
    public class DrugCategory : TranslationEntity<TranslatedDrugsCategory>
    {
        public List<Drug> Drugs { get; } = new();
    }
}