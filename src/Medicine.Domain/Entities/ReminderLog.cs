using Medicine.Domain.Entities.Base;

namespace Medicine.Domain.Entities
{
    public class ReminderLog : Entity
    {
        public DosageRecommendation DosageRecommendation { get; set; }
        public ReminderLogStatus Status { get; set; }
        public double Quantity { get; set; }
        public DateTime DateTime { get; set; }
    }
}
