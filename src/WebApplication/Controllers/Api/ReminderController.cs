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

        //var dosageRecomendation = await _context.DosageRecommendations.FindAsync(1);




        //await _context.SaveChagesAsync();
        //_context.ChangeTracker.Clear();

        //DateTime firstData = new DateTime(1900, 1, 3, 7, 20, 0, 0);

        //var lang = Language.en;


        //var therapy = _context.Reminders
        //    .Where(
        //        reminder => reminder.TimeInUtc == firstData.ToString("HH:mm") && reminder.UserId == userId
        //         &&
        //       (
        //        reminder.DosageRecommendations.Any(x => x.DosageLogs == null)
        //            ||
        //        reminder.DosageRecommendations.Any(x => x.DosageLogs.Any(
        //            y => y.DateTime.AddDays(y.DosageRecommendation.DosingFrequency.IntervalInDays) <= firstData
        //        )))
        //    )
        //    .Include(reminder => reminder.DosageRecommendations)
        //        .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
        //    .Include(reminder => reminder.DosageRecommendations)
        //        .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
        //        .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
        //    .Include(reminder => reminder.DosageRecommendations)
        //        .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
        //        .ThenInclude(doseFrequency => doseFrequency.Course)
        //        .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
        //    .Include(reminder => reminder.DosageRecommendations)
        //        .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
        //        .ThenInclude(doseFrequency => doseFrequency.Course)
        //        .ThenInclude(course => course.Therapy)
        //        .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
        //    .Include(reminder => reminder.DosageRecommendations)
        //        .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
        //        .ThenInclude(doseFrequency => doseFrequency.Drug)
        //        .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
        //   .Include(reminder => reminder.DosageRecommendations)
        //        .ThenInclude(dosageRecomendation => dosageRecomendation.DosageLogs.Where(x => x.UserId == userId))
        //        .ToList();





        //return Json(therapy);


    }
}
