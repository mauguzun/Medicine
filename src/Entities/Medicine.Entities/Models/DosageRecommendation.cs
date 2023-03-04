using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    public class DosageRecommendation : Entity
    {
        public double Total { get; set; }
        public DosingFrequency DosingFrequency { get; set; }
        public TranslatedDosageRecommendation TranslatedDosageRecommendations { get; set; }
    }
}
