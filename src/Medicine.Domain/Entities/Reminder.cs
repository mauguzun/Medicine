using Medicine.Domain.Entities.Base;

namespace Medicine.Domain.Entities
{
    public class Reminder : EntityWithDescriptionEntityTransate
    {
        public TimeOnly Time { get; set; } = new TimeOnly(0, 0);
        public List<DosageRecommendation>? DosageRecommendations { get; set; }
    }
}
