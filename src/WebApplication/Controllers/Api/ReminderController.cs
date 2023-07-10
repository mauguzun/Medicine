using HotChocolate.Authorization;
using Medicine.Application.Interfaces;
using Medicine.Entities.Enums;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Auth;
using Medicine.Entities.Models.Translated;
using Medicine.Infrastructure.Implementation.DataAccesMssql;
using Medicine.Web.UseCases.Auth.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

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


        public IList<Reminder> Get()
        {
            return _reminderService.Get();
        }



    }
}
