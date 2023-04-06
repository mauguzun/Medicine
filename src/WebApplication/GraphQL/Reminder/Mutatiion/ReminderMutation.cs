using AutoMapper;
using Medicine.DataAccess.Sql;
using Medicine.Web.UseCases.Reminder.Dto;

namespace Medicine.WebApplication.GraphQL.Reminder.Queries
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

            var current =  ctx.Reminders.Find(reminder.Id);
            current.Title = reminder.Title;
            current.Descrptioin = reminder.Descrptioin;

            ctx.Update(current);
            ctx.SaveChanges();

            return mapper.Map<ReminderDto>(current);
        }
    }

}