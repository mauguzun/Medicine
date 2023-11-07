using Medicine.Web.UseCases.DataLoaders.DataLoader;
using Medicine.Web.UseCases.Responses;
using Microsoft.EntityFrameworkCore;

namespace Medicine.WebApplication.GraphQL.Reminders
{
    public class ReminderQuery
    {

        [UseProjection]
        [UseSorting()]
        [UseFiltering()]
        public async Task<IEnumerable<ReminderDto>> Find(
            IResponseLoader<int, Entities.Models.Reminder, ReminderDto> dataLoader)
        {
            var reminder = await dataLoader.LoadAsync();
            return reminder;
        }

    }

}