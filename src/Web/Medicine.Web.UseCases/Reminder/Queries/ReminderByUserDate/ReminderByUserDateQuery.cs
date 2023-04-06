using MediatR;
using Medicine.Web.UseCases.Reminder.Dto;

namespace Medicine.Web.UseCases.Reminder.Queries.ReminderByUserDate
{
    public class ReminderByUserDateQuery : IRequest<List<ReminderDto>>
    {
        public int UserId { get; set; }
    }


}
