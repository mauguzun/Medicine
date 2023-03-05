using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    public class Reminder : EntityWithDescription
    {
        public TimeOnly TimeInUtc { get; set; } = new TimeOnly(0, 0);
        public List<DosageRecommendation> DosageRecommendations { get; set; } = new List<DosageRecommendation>();
    }
}
