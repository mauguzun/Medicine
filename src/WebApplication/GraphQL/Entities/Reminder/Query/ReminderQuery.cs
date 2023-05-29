using Medicine.Web.UseCases.Responses;
using Medicine.Web.UseCases.Responses.BaseDataLoader;
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