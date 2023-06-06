using Medicine.Web.UseCases.DataLoaders.BaseDataLoader;
using Medicine.Web.UseCases.Responses;
using Microsoft.EntityFrameworkCore;

namespace Medicine.WebApplication.GraphQL.Entities.Reminder.Query
{

    public class ReminderQuery
    {

        [UseProjection]
        [UseSorting()]
        [UseFiltering()]
        public async Task<IEnumerable<ReminderResponse>> GetAll(
            IResponseLoader<int, Medicine.Entities.Models.Reminder, ReminderResponse> dataLoader)
        {
            var reminder = await dataLoader.LoadAsync();
            return reminder;
        }



    }

}