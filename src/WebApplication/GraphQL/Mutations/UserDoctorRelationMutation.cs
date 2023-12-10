using AutoMapper;
using HotChocolate.Authorization;
using Medicine.Entities.Models.Reminders;
using Medicine.Infrastructure.Implementation.DataAccesPsql;
using Medicine.Web.UseCases.Models.GraphqlResponse.Reminder;

namespace Medicine.WebApplication.GraphQL.Mutations
{
    [Authorize]
    public class ReminderMutation
    {
        [UseSorting()]
        [UseFiltering()]
        public ReminderResponse UpdateReminder(
            [Service] AppDbContext ctx,
            [Service] IMapper mapper,
            ReminderResponse reminderDto)
        {
            var current = ctx.Reminders.Find(reminderDto.Id);
            if(current == null)
            {
                
            }
            current.Title = reminderDto.Title;
            current.Description = reminderDto.Description;
            current.TimeInUtc = reminderDto.TimeInUtc;

            ctx.Update(current);
            ctx.SaveChanges();

            return mapper.Map<ReminderResponse>(current);
        }


        [UseSorting()]
        [UseFiltering()]
        public ReminderResponse AddReminder(
            [Service] AppDbContext ctx,
            [Service] IMapper mapper,
            ReminderResponse reminderDto)
        {
            var reminder = mapper.Map<Reminder>(reminderDto);
            var current = ctx.Reminders.Add(reminder);
            ctx.SaveChanges();

            return mapper.Map<ReminderResponse>(reminder);
        }
    }

}