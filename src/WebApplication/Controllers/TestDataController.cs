using Medicine.DataAccess.Sql;
using Medicine.Entities.Enums;
using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Medicine.DataAccess.Interfaces;
using static HotChocolate.ErrorCodes;

namespace Medicine.WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestDataController : Controller
    {
        private readonly AppDbContext _context;

        public TestDataController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            int userId = 1;

            _context.Drugs.Add(new Drug
            {
                CreatedBy = userId,
                OneUnitSizeInGramm = 11.22,
                TranslatedDrugs =
                {
                     new TranslatedDrugs {    Title = "Drug Name", Descrptioin = "Drug Descrption" },
                     new TranslatedDrugs {    Title = "Drug Name", Descrptioin = "Drug Descrption", Language = Language.en }
                },
                Recomendation = "use before eat 15 min",
                Title = "Citramonium"
            });

            await _context.SaveChagesAsync();

            _context.Therapies.Add(
                new Therapy
                {
                    CreatedBy = userId,

                    Type = TherapyType.AutoCreated,
                    Status = TherapyStatus.Statret,
                    TranslatedTherapies = {
                       new TranslatedTherapy
                       {
                           Title = "AutoCrated", Descrptioin = "AutoCreated"
                       },
                       new TranslatedTherapy
                       {
                            Title = "AutoCrated2", Descrptioin = "AutoCreated2",Language = Language.lv
                       }
                    },
                    Courses =
                    {
                       new Course
                       {
                             CreatedBy = userId,
                             TranslatedCourses ={
                               new TranslatedCourse { Title = "AutoCrated2", Descrptioin = "AutoCreated2",Language = Language.lv },
                               new TranslatedCourse { Title = "AutoCrated", Descrptioin = "AutoCreated"}
                           },
                           DosingFrequencies =
                           {
                               new DosingFrequency
                               {
                                    Total = 10,
                                    Drug =  _context.Drugs.FirstOrDefault(),
                                    IntervalInDays = 2,
                                    DosageRecommendations =
                                   {
                                       new DosageRecommendation{
                                            Quantity  = 1,
                                             TranslatedDosageRecommendations =
                                           {
                                                new TranslatedDosageRecommendation { Title = "AutoCrated", Descrptioin = "AutoCreated"}
                                           }
                                       }
                                   }
                               }
                           }
                       }
                    }
                });

            await _context.SaveChagesAsync();

            var dosageRecomendation = await _context.DosageRecommendations.FindAsync(1);

            _context.Reminders.Add(new Reminder
            {
                CreatedBy = userId,
                Title = "Morning Reminder",
                TimeInUtc = "07:20",
                DosageRecommendations = { dosageRecomendation }
            });

            _context.Reminders.Add(new Reminder { CreatedBy = userId, Title = "Evning Reminder", TimeInUtc = "0:20" });


            _context.DosageLogs.Add(new DosageLog
            {
                CreatedBy = userId,
                Quantity = 1,
                DosageRecommendation = dosageRecomendation,
                DateTime = new DateTime(1900, 1, 1, 7, 20, 0, 0)
            });


            await _context.SaveChagesAsync();
            _context.ChangeTracker.Clear();

            DateTime firstData = new DateTime(1900, 1, 3, 7, 20, 0, 0);

            //var remider = _context.Reminders
            //    .Where(
            //        reminder => reminder.TimeInUtc == firstData.ToString("HH:mm")
            //         &&
            //       (
            //        reminder.DosageRecommendations.Any(x => x.DosageLogs == null)
            //            ||
            //        reminder.DosageRecommendations.Any(x => x.DosageLogs.Any(
            //            y=>y.DateTime.AddDays(y.DosageRecommendation.DosingFrequency.IntervalInDays) <= firstData
            //        )))
            //    )
            //    .Include(reminder => reminder.DosageRecommendations)
            //        .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
            //        .ThenInclude(doseFrequency => doseFrequency.Course)
            //        .ThenInclude(course => course.Therapy)
            //    .Include(reminder => reminder.DosageRecommendations)
            //        .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
            //        .ThenInclude(doseFrequency => doseFrequency.Drug)
            //        .ThenInclude(dose => dose.TranslatedDrugs)
            //   .Include(reminder => reminder.DosageRecommendations)
            //        .ThenInclude(dosageRecomendation => dosageRecomendation.DosageLogs.Where(x => x.CreatedBy == userId))
            //.ToList();




            return Json(null);

        }
    }
}
