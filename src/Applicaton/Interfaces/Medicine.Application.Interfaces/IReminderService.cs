using Medicine.Entities.Models.Reminders;

namespace Medicine.Application.Interfaces
{
    public interface IReminderService
    {
        public Task<IList<Reminder>> Get();
    }
}
