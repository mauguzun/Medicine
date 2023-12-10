using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Reminders;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models.Dosages
{
    /// <summary>
    /// Created by user ,contains link to dosingfrequence, reminder , and quantity
    /// </summary>
    public class DosingFrequencyReminder : EntityUser
    {
        public string Title { get; set; }
        public string UsingDescription { get; set; }

        public double Quantity { get; set; }
        public int ReminderId { get; set; }
        public Reminder Reminder { get; set; }
        public int DosingFrequencyId { get; set; }
        public DosingFrequency DosingFrequency { get; set; }
        public List<DosageLog> DosageLogs { get; set; } = new List<DosageLog>();
    }
}
