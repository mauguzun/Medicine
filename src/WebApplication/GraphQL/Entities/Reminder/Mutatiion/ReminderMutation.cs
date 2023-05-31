using AutoMapper;
using Medicine.Infrastructure.Implementation.DataAccesMssql;
using Medicine.Web.UseCases.CQRS.Reminder.Dto;

namespace Medicine.WebApplication.GraphQL.Entities.Reminder.Mutatiion
{

    public class ReminderMutation
    {
        [UseSorting()]
        [UseFiltering()]
        public async Task<ReminderDto> UpdateReminder(
            [Service] AppDbContext ctx,
            [Service] IMapper mapper,
            ReminderDto reminder)
        {

            var current = ctx.Reminders.Find(reminder.Id);
            current.Title = reminder.Title;
            current.Descrptioin = reminder.Descrptioin;

            ctx.Update(current);
            ctx.SaveChanges();

            return mapper.Map<ReminderDto>(current);
        }
    }

}