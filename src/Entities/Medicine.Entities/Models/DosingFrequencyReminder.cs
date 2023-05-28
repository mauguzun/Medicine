using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    /// <summary>
    /// Created by user , 
    /// </summary>
    public class DosingFrequencyReminder : TranslationsEntityByUserWith<TranslatedDosingFrequencyReminder>
    {
        public double Quantity { get; set; }
        public int ReminderId { get; set; }
        public Reminder Reminder { get; set; }
        public int DosingFrequencyId { get; set; }
        public DosingFrequency DosingFrequency { get; set; }
        public List<DosageLog> DosageLogs { get; set; } = new List<DosageLog>();
    }
}
