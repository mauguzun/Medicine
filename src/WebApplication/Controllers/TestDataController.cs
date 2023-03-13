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
                Translations = new List<TranslatedDrugs>
                {
                     new TranslatedDrugs {    Title = "Drug Name", Description = "Drug Descrption" },
                     new TranslatedDrugs {    Title = "Drug Name", Description = "Drug Descrption", Language = Language.lv }
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
                    Translations = new  List<TranslatedTherapy> {
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
                             CreatedBy = userId,
                             Translations = new  List<TranslatedCourse>  {
                               new TranslatedCourse { Title = "AutoCrated2", Description = "AutoCreated2",Language = Language.lv },
                               new TranslatedCourse { Title = "AutoCrated", Description = "AutoCreated"}
                           },
                           DosingFrequencies = new List<DosingFrequency>
                           {
                               new DosingFrequency
                               {
                                    Total = 10,
                                    Drug =  _context.Drugs.FirstOrDefault(),
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
                                    DosageRecommendations =
                                   {
                                       new DosageRecommendation{
                                            Quantity  = 1,
                                             Translations = new List<TranslatedDosageRecommendation>
                                           {
                                                new TranslatedDosageRecommendation { 
                                                    Title = "AutoCrated", Description = "AutoCreated"}
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
                DosageRecommendations =  new List<DosageRecommendation>{ dosageRecomendation }
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

            var lang = Language.en;

            var remider = _context.Reminders
                .Where(
                    reminder => reminder.TimeInUtc == firstData.ToString("HH:mm")
                     &&
                   (
                    reminder.DosageRecommendations.Any(x => x.DosageLogs == null)
                        ||
                    reminder.DosageRecommendations.Any(x => x.DosageLogs.Any(
                        y => y.DateTime.AddDays(y.DosageRecommendation.DosingFrequency.IntervalInDays) <= firstData
                    )))
                )

                .Include(reminder => reminder.DosageRecommendations)
                     .ThenInclude(translations => translations.Translations.Where(x=>x.Language == lang).FirstOrDefault())
                
                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(translations => translations.Translations.Where(x => x.Language == lang).FirstOrDefault())

                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Course)
                    .ThenInclude(translations => translations.Translations.Where(x => x.Language == lang).FirstOrDefault())

                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Course)
                    .ThenInclude(course => course.Therapy)
                    .ThenInclude(translations => translations.Translations.Where(x => x.Language == lang).FirstOrDefault())

                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Drug)
                    .ThenInclude(dose => dose.Translations)
               .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosageLogs.Where(x => x.CreatedBy == userId))
            .ToList();




            return Json(remider);

        }
    }
}
