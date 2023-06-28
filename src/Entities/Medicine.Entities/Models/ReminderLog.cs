using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    public class ReminderLog : Entity
    {
        public int ReminderId { get; set; } 
        public Reminder? Reminder { get; set; } 
        public Enums.ReminderLogStatus ReminderLogStatus { get; set; } 
        public string? Descrpition { get; set; } 

    }
}
