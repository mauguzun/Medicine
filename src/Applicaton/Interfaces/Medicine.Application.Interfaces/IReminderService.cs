using Medicine.Entities.Models;

namespace Medicine.Application.Interfaces
{
    public interface IReminderService
    {
        public Task<IList<Reminder>> Get();
    }
}
