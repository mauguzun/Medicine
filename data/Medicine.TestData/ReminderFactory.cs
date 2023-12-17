using Medicine.Entities.Models.Dosages;
using Medicine.Entities.Models.Reminders;

namespace Medicine.TestData
{
    public static class ReminderFactory
    {
        public static List<Reminder> Reminders(int userId, List<string> timeSlots)
        {
            var reminders = new List<Reminder>();
            timeSlots.ForEach(time =>
            {
                reminders.Add(new Reminder
                {
                    CreatedById = userId,
                    Title = $"Title {time} Reminders",
                    Description = $"Description {time} Reminders",
                    TimeInUtc = time
                });

            });
            return reminders;
        }

        public static DosingFrequencyReminder DosingFrequencyReminder (int reminderId , int dosingFreqencyId)
        {
            var dosingFreqency = new DosingFrequencyReminder
            {
                Quantity = 1,
                ReminderId = reminderId,
                Title = $"Titleb {reminderId} {dosingFreqencyId}",
                UsingDescription = $"UsingDescription {reminderId} {dosingFreqencyId}",
                DosingFrequencyId = dosingFreqencyId
            };

            return dosingFreqency;
        }
    }
}
