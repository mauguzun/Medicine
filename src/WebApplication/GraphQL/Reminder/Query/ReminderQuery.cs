using AutoMapper;
using HotChocolate.Authorization;
using Medicine.DataAccess.Sql;
using Medicine.Entities.Enums;
using Medicine.Entities.Models;
using Medicine.Web.UseCases.Reminder.Dto;
using Medicine.WebApplication.GraphQL.DataLoaders;
using Medicine.WebApplication.GraphQL.Reminder.Response;
using Microsoft.EntityFrameworkCore;

namespace Medicine.WebApplication.GraphQL.Reminder.Query
{

    public class ReminderQuery
    {

        //[UseProjection]
        //[UseSorting()]
        //[UseFiltering()]
        public async Task<IEnumerable<ReminderResponse>> GetAll(
            IDataLoader<int, ReminderResponse> dataLoader
          )
        {
            var reminder = await dataLoader.LoadAsync();
            return reminder;
        }


        [Authorize(Roles = new[] { nameof(SystemRole.User) })]
        [UseProjection]
        [UseSorting()]
        [UseFiltering()]
        public List<Entities.Models.Reminder> Logined(
         [Service] IHttpContextAccessor context,
         [Service] AppDbContextReadOnly ctx,
         [Service] IMapper mapper
        )
        {
            var user = context.HttpContext.User;
            return ctx.Reminders.ToList();
        }
    }

}