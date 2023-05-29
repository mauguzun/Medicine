using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    /// <summary>
    /// User create reminder select time and then can assing drugs for this reminder 
    /// for example each day in 17:00
    /// </summary>
    public class Reminder : EntityTitleDescription
    {
        public string TimeInUtc { get; set; } = "00:00";
        public List<DosingFrequencyReminder> DosageRecommendations { get; set; } = new List<DosingFrequencyReminder>(); 

    }
}
