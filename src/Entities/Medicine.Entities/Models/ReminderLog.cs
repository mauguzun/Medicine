using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    public class ReminderLog : EntityByUser
    {
        public DosageRecommendation DosageRecommendation { get; set; }
        public ReminderLogStatus Status { get; set; }
        public double Quantity { get; set; }
        public DateTime DateTime { get; set; }
    }
}
