using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    public class DosageLog : EntityAuthor
    {
        public int DosageRecommendationId { get; set; }
        public DosingFrequencyReminder DosageRecommendation { get; set; }
        public Enums.DosageLogStatus Status { get; set; }
        public double Quantity { get; set; }
        public DateTime DateTime { get; set; }
    }
}
