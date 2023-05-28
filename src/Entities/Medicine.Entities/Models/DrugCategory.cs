using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    /// <summary>
    /// Drug category , can containt many drugs
    /// </summary>
    public class DrugCategory : TranslationsEntityByUserWith<TranslatedDrugsCategory>
    {
        public int DrugId { get; set; }
        public List<Drug> Drugs { get; set; } = new List<Drug>();   
    }
}