using Medicine.Entities.Enums;
using Medicine.Entities.Models.Auth;
using Medicine.Entities.Models.Courses;
using Medicine.Entities.Models.Dosages;
using Medicine.Entities.Models.Drugs;
using Medicine.Entities.Models.Reminders;
using Medicine.Entities.Models.Therapies;
using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models.UserDoctor;
using Medicine.Infrastructure.Interfcases.DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Medicine.WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestDataController : Controller
    {
        private readonly IAppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<User> _roleManager;

        public TestDataController(IAppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public async Task<IActionResult> IndexAsync()
        {
            var (user, doctor) = await CreateUsers();

            await CreateUserDoctorRelation(user, doctor);

            var userId = user.Id;
            await CreateActiveElements();

            var drugsCategories = await CreateDrugsCategoriesAsync();
            await CreateDrugs(userId, drugsCategories);

            await CreateReminder(userId);

           

            var course = await CreateCourseAsync(userId);
            var dosingFreqency = await DosingFrequencyReminderAsync(_context.Reminders.First().Id ,course.DosingFrequencies.First().Id);

            await CreateTherapy(userId, course);

            return Ok();

        }

        private async Task<DosingFrequencyReminder> DosingFrequencyReminderAsync(int reminderId,int dosingFreqencyId)
        {
            var dosingFreqency = new DosingFrequencyReminder
            {
                Quantity = 1,
                ReminderId = reminderId,
                Title = "Title",
                UsingDescription = "before eat",
                DosingFrequencyId = dosingFreqencyId
            };

            _context.DosingFrequencyReminders.Add(dosingFreqency);
            await _context.SaveChagesAsync();
            return dosingFreqency;
        }

        private async Task CreateReminder(int userId)
        {
            _context.Reminders.Add(new Reminder
            {
                CreatedById = userId,
                Title = "Morning Reminder",
                TimeInUtc = "07:20"
            });

            await _context.Reminders.AddAsync(new Reminder { CreatedById = userId, Title = "Evning Reminder", TimeInUtc = "0:20" });

            await _context.SaveChagesAsync();
        }

        private async Task<Course> CreateCourseAsync(int userId)
        {
            var course = new Course
            {
                CreatedById = userId,
                Translations = new List<TranslatedCourse>  {
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
                               }
                           }
            };

            await _context.Courses.AddAsync(course);
            await _context.SaveChagesAsync();
            return course;
        }

        private async Task CreateTherapy(int userId, Course course)
        {
            _context.Therapies.Add(
                new Therapy
                {
                    AssingedToId = userId,

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
                      course
                    }
                });

            await _context.SaveChagesAsync();
        }

        private async Task CreateDrugs(int userId, List<DrugCategory> drugsCategories)
        {
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
                    CreatedById = userId,
                    OneUnitSizeInGramm = i + 1,
                    Translations = translations,
                    Title = $"Drug LatinName {i}",
                    DrugCategories = drugsCategories
                };
                drugs.Add(drug);
            }

            similarDrugs.SimilarDrugsList = drugs;

            _context.Drugs.AddRange(drugs);
            //_context.SimilarDrugs.Add(similarDrugs);

            await _context.SaveChagesAsync();
        }

        private async Task<List<DrugCategory>> CreateDrugsCategoriesAsync()
        {
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
            await _context.SaveChagesAsync();

            return drugsCategories;
        }

        #region drugs

        private async Task CreateActiveElements()
        {
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
            await _context.SaveChagesAsync();
        }

        #endregion;


        #region users 
        private async Task CreateUserDoctorRelation(User user, User doctor)
        {
            UserDoctorRelation userDoctorRelactions = new UserDoctorRelation()
            {
                CreatedBy = user,
                MedicineWorker = doctor,
                CreatedByUser = true
            };

            _context.UserDoctorRelations.Add(userDoctorRelactions);
            await _context.SaveChagesAsync();
        }
        private async Task<(User User, User Doctor)> CreateUsers()
        {
            var user = new User()
            {
                Birthday = DateOnly.FromDateTime(DateTime.UtcNow),
                Email = "mauguzun@gmail.com",
                EmailConfirmed = true,
                UserName = "ma",
            };
            var doctror = new User()
            {
                Birthday = DateOnly.FromDateTime(DateTime.UtcNow),
                Email = "mauguzun+doctor@gmail.com",
                EmailConfirmed = true,
                Role = SystemRole.MedicineWorker,
                UserName = "doc",
            };
            _context.SaveChanges();

            return (User: user, Doctor: doctror);

        }
        #endregion
    }
}
