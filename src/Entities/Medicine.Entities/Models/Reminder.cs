using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    public class Reminder : EntityWithDescription
    {
        public string TimeInUtc { get; set; } = "00:00";
        public List<DosageRecommendation> DosageRecommendations { get; set; } = new List<DosageRecommendation>(); 
    }
}
