using Medicine.Entities.Enums;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Auth;
using Medicine.Entities.Models.Courses;
using Medicine.Entities.Models.Dosages;
using Medicine.Entities.Models.Drugs;
using Medicine.Entities.Models.Reminders;
using Medicine.Entities.Models.Therapies;
using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models.UserDoctor;
using Medicine.Infrastructure.Implementation.DataAccesPsql;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Medicine.WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestDataController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<User> _roleManager;

        public TestDataController(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

  

        public async Task<IActionResult> IndexAsync()
        {
            var (user, doctor) = await CreateUser();

            await CreateUserDoctorRelation(user, doctor);

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
      
        }




        #region users 
        private async Task CreateUserDoctorRelation(User user, User doctor)
        {
            UserDoctorRelation userDoctorRelactions = new UserDoctorRelation()
            {
                User = user,
                MedicineWorker = doctor,
                CreatedByUser = true
            };

            _context.UserDoctorRelations.Add(userDoctorRelactions);
            await _context.SaveChagesAsync();
        }
        private async Task<(User User, User Doctor)> CreateUser()
        {
            var user = new User()
            {
                Birthday = DateOnly.FromDateTime(DateTime.UtcNow),
                Email = "mauguzun@gmail.com",
                EmailConfirmed = true,
                UserName = "ma",
            };
            await _userManager.CreateAsync(user, "De171717!");
            await _userManager.AddToRoleAsync(user, SystemRole.User.ToString());

            var doctror = new User()
            {
                Birthday = DateOnly.FromDateTime(DateTime.UtcNow),
                Email = "mauguzun+doctor@gmail.com",
                EmailConfirmed = true,
                UserName = "doc",
            };
            await _userManager.CreateAsync(user, "De171717!");
            await _userManager.AddToRoleAsync(user, SystemRole.User.ToString());

            _context.SaveChanges();

            return (User: user, Doctor: doctror);

        }
        #endregion
    }
}
