using HotChocolate.Authorization;
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
    [ApiController]
    [Route("[controller]")]
    public class TestDataController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;

        public TestDataController(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> IndexAsync()
        {

            var user = new User()
            {
                Birthday = DateTimeOffset.UtcNow,
                Email = "mauguzun@gmail.com",
                EmailConfirmed  = true
            };
            var result = await _userManager.CreateAsync(user, "De171717!");

            _context.Users.Add(user);
            _context.SaveChanges();

            var userId = user.Id;

            var activeElements = new List<ActiveElement>();
            for (int i = 0; i < 2; i++)
            {
                var translates = new List<TranslatedActiveElement>();
                foreach (Language lang in Enum.GetValues(typeof(Language)))
                {
                    translates.Add(new TranslatedActiveElement()
                    {
                        Language = lang,
                        Title = $"{i} {nameof(TranslatedActiveElement)}  Title {lang}",
                        Description = $"{i} {nameof(TranslatedActiveElement)}  Description  {lang}",
                    });
                }

                ActiveElement activeElement = new()
                {
                    Quantity = i + 1,
                    Translations = translates
                };
            }

            _context.ActiveElements.AddRange(activeElements);
            _context.SaveChanges();

            var drugsCategories = new List<DrugCategory>();

            for (int i = 0; i < 4; i++)
            {
                var translations = new List<TranslatedDrugsCategory>();
                foreach (Language lang in Enum.GetValues(typeof(Language)))
                {
                    translations.Add(new TranslatedDrugsCategory()
                    {
                        Language = lang,
                        Title = $"{i} {nameof(TranslatedActiveElement)}  {lang}",
                        Description = $"{i} {nameof(DrugCategory)}  Description  {lang}",
                    });
                }

                drugsCategories.Add(new DrugCategory { Translations = translations });
             
            }
            _context.DrugCategories.AddRange(drugsCategories);
            _context.SaveChanges();


            var similarDrugs = new SimilarDrugs();


            var drugs = new List<Drug>();
            for (int i = 0; i < 2; i++)
            {
                var translations = new List<TranslatedDrugs>();
                foreach (Language lang in Enum.GetValues(typeof(Language)))
                {
                    translations.Add(new TranslatedDrugs()
                    {
                        Language = lang,
                        Title = $"{i} {nameof(TranslatedDrugs)}  {lang} ",
                        Description = $"{i} {nameof(TranslatedDrugs)}  Description  {lang}",
                        Recomendation = "Use befor"
                    });
                }

                var drug = new Drug
                {
                    UserId = userId,
                    OneUnitSizeInGramm = i + 1,
                    Translations = translations,
                    Title = $"Drug LatinName {i}",
                    DrugCategories = drugsCategories
                };
                drugs.Add(drug);
            }

            similarDrugs.SimilarDrugsList = drugs;

            _context.Drugs.AddRange(drugs);
            _context.SimilarDrugs.Add(similarDrugs);

            _context.SaveChanges();

            _context.Reminders.Add(new Reminder
            {
                UserId = userId,
                Title = "Morning Reminder",
                TimeInUtc = "07:20"
            });

            _context.Reminders.Add(new Reminder { UserId = userId, Title = "Evning Reminder", TimeInUtc = "0:20" });

            _context.SaveChanges();

            var dosingFreqency = new DosingFrequencyReminder
            {
                Quantity = 1,
                ReminderId = _context.Reminders.FirstOrDefault().Id,
                Title = "Title",
                UsingDescription = "before eat"
            };

            _context.DosingFrequencyReminders.Add(dosingFreqency);


            var course = new List<Course>();


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
                                    DosingFrequencyReminders = new List<DosingFrequencyReminder>(){ dosingFreqency }

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
