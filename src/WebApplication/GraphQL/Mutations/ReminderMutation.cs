using AutoMapper;
using HotChocolate.Authorization;
using Medicine.Entities.Models;
using Medicine.Infrastructure.Implementation.DataAccesMssql;
using Medicine.Web.UseCases.Responses;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Numerics;

namespace Medicine.WebApplication.GraphQL.Mutations
{
    [Authorize]
    public class ReminderMutation
    {
        [UseSorting()]
        [UseFiltering()]
        public ReminderDto UpdateReminder(
            [Service] AppDbContext ctx,
            [Service] IMapper mapper,
            ReminderDto reminderDto)
        {
            var current = ctx.Reminders.Find(reminderDto.Id);
            if(current == null)
            {
                
            }
            current.Title = reminderDto.Title;
            current.Descrptioin = reminderDto.Descrptioin;
            current.TimeInUtc = reminderDto.TimeInUtc;

            ctx.Update(current);
            ctx.SaveChanges();

            return mapper.Map<ReminderDto>(current);
        }


        [UseSorting()]
        [UseFiltering()]
        public ReminderDto AddReminder(
            [Service] AppDbContext ctx,
            [Service] IMapper mapper,
            ReminderDto reminderDto)
        {
            var reminder = mapper.Map<Reminder>(reminderDto);
            var current = ctx.Reminders.Add(reminder);
            ctx.SaveChanges();

            return mapper.Map<ReminderDto>(reminder);
        }
    }

}