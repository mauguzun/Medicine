using Medicine.Domain.Entities.Base;
using Medicine.Domain.Entities.Translated;

namespace Medicine.Domain.Entities
{
    public class DosageRecommendation : Entity
    {
        public double Total { get; set; }
        public DosingFrequency DosingFrequency { get; set; }

        public List<TranslatedDosageRecommendation> TranslatedDosageRecommendations { get; set; }
    }
}
