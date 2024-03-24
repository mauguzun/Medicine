using Medicine.Entities.Models.Reminders;
using Medicine.Web.UseCases.DataLoaders.DataLoader;
using Medicine.Web.UseCases.Models.GraphqlResponse.Reminder;
using Microsoft.EntityFrameworkCore;

namespace Medicine.WebApplication.GraphQL.Queries.Reminders
{
    [ExtendObjectType(nameof(Queries))]
    public class ReminderQuery
    {
        [UseProjection]
        [UseSorting()]
        [UseFiltering()]
        public async Task<IEnumerable<ReminderResponse>> ReminderFind(
            IResponseLoader<int, Reminder, ReminderResponse> dataLoader)
        {
            var reminder = await dataLoader.LoadAsync();
            return reminder;
        }

    }

}