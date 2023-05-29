using Medicine.DataAccess.Sql;
using Medicine.Entities.Enums;
using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Medicine.DataAccess.Interfaces;
using static HotChocolate.ErrorCodes;
using Medicine.Entities.Models.Auth;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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

        public IActionResult Index()
        {




            var user = new User()
            {
                Birthday = DateTime.Now,
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            var userId = user.Id;

            _context.Drugs.Add(new Drug
            {
                UserId = userId,
                OneUnitSizeInGramm = 11.22,
                Translations = new List<TranslatedDrugs>
                {
                     new TranslatedDrugs {    Title = "Drug Name", Description = "Drug Descrption",      Recomendation = "use before eat 15 min",  },
                     new TranslatedDrugs {    Title = "Drug Name", Description = "Drug Descrption",     Recomendation = "use before eat 15 min",  Language = Language.lv }
                },

                Title = "Citramonium"
            });
            _context.SaveChanges();


            _context.Reminders.Add(new Reminder
            {
                UserId = userId,
                Title = "Morning Reminder",
                TimeInUtc = "07:20"
            });

            _context.Reminders.Add(new Reminder { UserId = userId, Title = "Evning Reminder", TimeInUtc = "0:20" });


            _context.SaveChanges();


            _context.Therapies.Add(
                new Therapy
                {
                    UserId = userId,

                    Type = TherapyType.AutoCreated,
                    Status = TherapyStatus.Statret,
                    Translations = new List<TranslatedTherapy> {
                       new TranslatedTherapy
                       {
                           Title = "AutoCrated", Description = "AutoCreated"
                       },
                       new TranslatedTherapy
                       {
                            Title = "AutoCrated2", Description = "AutoCreated2",Language = Language.lv
                       }
                    },
                    Courses = new List<Course>
                    {
                       new Course
                       {
                             UserId = userId,
                             Translations = new  List<TranslatedCourse>  {
                               new TranslatedCourse { Title = "AutoCrated2", Description = "AutoCreated2",Language = Language.lv },
                               new TranslatedCourse { Title = "AutoCrated", Description = "AutoCreated"}
                           },
                           DosingFrequencies = new List<DosingFrequency>
                           {
                               new DosingFrequency
                               {
                                    Total = 10,
                                    DrugId =  _context.Drugs.FirstOrDefault().Id,
                                    IntervalInDays = 2,
                                    Translations =  new List<TranslatedDosingFrequency>
                                    {
                                         new TranslatedDosingFrequency
                                         {
                                             Title = "TranslatedDosingFrequency",
                                             Description =  "TranslatedDosingFrequency Description"
                                         },
                                          new TranslatedDosingFrequency
                                         {
                                             Title = "TranslatedDosingFrequency",
                                             Description =  "TranslatedDosingFrequency Description",
                                             Language = Language.lv
                                         }
                                    },
                                    DosingFrequencyReminders =
                                   {
                                       new DosingFrequencyReminder{
                                            Quantity  = 1,
                                            ReminderId  = _context.Reminders.FirstOrDefault().Id,
                                            Title = "Title",
                                            UsingDescription ="before eat"

                                       }
                                   }
                               }
                           }
                       }
                    }
                });

            _context.SaveChanges();

            return Ok();
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
}
