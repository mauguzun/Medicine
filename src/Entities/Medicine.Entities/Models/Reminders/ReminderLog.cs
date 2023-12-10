using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models.Reminders
{
    public class ReminderLog : Entity
    {
        public ReminderLog(int reminderId) => ReminderId = reminderId;

        public int ReminderId { get; set; }
        public Reminder? Reminder { get; set; }
        public ReminderLogStatus ReminderLogStatus { get; private set; }

        public string? Descrpition { get; set; }

        public void SetReminderLogStatus(ReminderLogStatus reminderLogStatus)
        {
            ReminderLogStatus = (reminderLogStatus, ReminderLogStatus) switch
            {
                (ReminderLogStatus.Readed, ReminderLogStatus.None) => ReminderLogStatus.Readed,
                _ => throw new NotImplementedException("Cant set create reminder status")
            };
        }


    }
}
