using Medicine.Application.Interfaces;
using Medicine.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace Medicine.WebApplication.Controllers
{

    [Route("Api/[controller]")]
    public class ReminderController : Controller
    {

        private readonly IReminderService _reminderService;

        public ReminderController(IReminderService reminderService)
        {
            _reminderService = reminderService;
        }

        public async Task<IList<Reminder>> GetAsync() => await _reminderService.Get();


    }
}
