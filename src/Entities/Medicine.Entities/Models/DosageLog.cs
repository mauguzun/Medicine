using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    public class DosageLog : EntityByUser
    {
        public int DosageRecommendationId { get; set; }
        public DosingFrequencyReminder DosageRecommendation { get; set; }
        public ReminderLogStatus Status { get; set; }
        public double Quantity { get; set; }
        public DateTime DateTime { get; set; }
    }
}
