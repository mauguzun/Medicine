using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    public class DosageRecommendation : EntityByUser
    {
        public double Quantity { get; set; }
        public List<TranslatedDosageRecommendation> TranslatedDosageRecommendations { get; set; } = new List<TranslatedDosageRecommendation>();

        public DosingFrequency DosingFrequency { get; set; }
        public List<DosageLog> DosageLogs { get; set; }
    }
}
