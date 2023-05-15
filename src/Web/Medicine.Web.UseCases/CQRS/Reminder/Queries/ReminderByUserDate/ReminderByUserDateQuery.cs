using MediatR;
using Medicine.Web.UseCases.CQRS.Reminder.Dto;

namespace Medicine.Web.UseCases.CQRS.Reminder.Queries.ReminderByUserDate
{
    public class ReminderByUserDateQuery : IRequest<List<ReminderDto>>
    {
        public int UserId { get; set; }
    }


}
