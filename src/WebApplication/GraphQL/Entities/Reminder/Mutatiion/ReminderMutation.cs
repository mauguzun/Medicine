using AutoMapper;
using HotChocolate.Authorization;
using Medicine.Infrastructure.Implementation.DataAccesMssql;
using Medicine.Web.UseCases.Responses;

namespace Medicine.WebApplication.GraphQL.Entities.Reminder.Mutatiion
{
    [Authorize]
    public class ReminderMutation
    {
        [UseSorting()]
        [UseFiltering()]
        public async Task<ReminderResponse> UpdateReminder(
            [Service] AppDbContext ctx,
            [Service] IMapper mapper,
            ReminderResponse reminder)
        {

            var current = ctx.Reminders.Find(reminder.Id);
            current.Title = reminder.Title;
            current.Descrptioin = reminder.Descrptioin;

            ctx.Update(current);
            ctx.SaveChanges();

            return mapper.Map<ReminderResponse>(current);
        }
    }

}