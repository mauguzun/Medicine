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
            DataLoader<Entities.Models.Reminder, ReminderResponse> dataLoader
          )
        {
            // nada chtobi bil dataloader bez kluchej ili chto v takom sluchae delat ?, i mne pochemu ta ne rabotat s int id . xotja v primeri rabotaet

            var  x = await dataLoader.LoadAsync();

            return x;
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