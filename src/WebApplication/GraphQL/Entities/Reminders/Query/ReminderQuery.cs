using AutoMapper;
using HotChocolate.Authorization;
using Medicine.DataAccess.Sql;
using Medicine.Entities.Enums;
using Medicine.WebApplication.GraphQL.BaseDataLoader;
using Medicine.WebApplication.GraphQL.Entities.Reminders.Response;
using Microsoft.EntityFrameworkCore;

namespace Medicine.WebApplication.GraphQL.Entities.Reminders.Query
{

    public class ReminderQuery
    {

        //[UseProjection]
        //[UseSorting()]
        //[UseFiltering()]
        public async Task<IEnumerable<ReminderResponse>> GetAll(
            IResponseLoader<int, Medicine.Entities.Models.Reminder, ReminderResponse> dataLoader )
        {
            var reminder = await dataLoader.LoadAsync();
            return reminder;
        }



    }

}