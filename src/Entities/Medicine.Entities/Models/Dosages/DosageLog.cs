using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models.Dosages
{
    public class DosageLog : EntityUser
    {
        public int DosageRecommendationId { get; set; }
        public DosingFrequencyReminder DosageRecommendation { get; set; }
        public DosageLogStatus Status { get; set; }
        public double Quantity { get; set; }
        public DateTime DateTime { get; set; }
    }
}
