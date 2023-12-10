using Medicine.Entities.Models.Reminders;
using Medicine.Web.UseCases.DataLoaders.DataLoader;
using Medicine.Web.UseCases.Models.GraphqlResponse.Reminder;
using Microsoft.EntityFrameworkCore;

namespace Medicine.WebApplication.GraphQL.Reminders
{
    public class ReminderQuery
    {

        [UseProjection]
        [UseSorting()]
        [UseFiltering()]
        public async Task<IEnumerable<ReminderResponse>> Find(
            IResponseLoader<int, Reminder, ReminderResponse> dataLoader)
        {
            var reminder = await dataLoader.LoadAsync();
            return reminder;
        }

    }

}