using Medicine.DataAccess.Sql;
using Medicine.Entities.Enums;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Translated;
using Microsoft.EntityFrameworkCore;

namespace UseCases
{
    public class LogicTest
    {
        [Fact]
        public async Task UnitTest1()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");

            var context = new AppDbContext(optionsBuilder.Options);

            int userId = 1;

            context.Drugs.Add(new Drug
            {
                Id = userId,
                OneUnitSizeInGramm = 11.22,
                Translations = new List<TranslatedDrugs>
                {
                     new TranslatedDrugs {    Title = "Drug Name", Description = "Drug Descrption" },
                     new TranslatedDrugs {    Title = "Drug Name", Description = "Drug Descrption", Language = Language.en }
                },
                Recomendation = "use before eat 15 min",
                Title = "Citramonium"
            });

            await context.SaveChagesAsync();

            context.Therapies.Add(
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
                    Courses =
                    {
                       new Course
                       {
                             UserId = userId,
                             Translations = new List<TranslatedCourse> {
                               new TranslatedCourse { Title = "AutoCrated2", Description = "AutoCreated2",Language = Language.lv },
                               new TranslatedCourse { Title = "AutoCrated", Description = "AutoCreated"}
                           },
                           DosingFrequencies =
                           {
                               new DosingFrequency
                               {
                                    Total = 10,
                                    Drug =  context.Drugs.Single(),
                                    IntervalInDays = 2,
                                    DosageReminders = new List<DosingFrequencyReminder>{
                                   {
                                       new DosingFrequencyReminder{
                                            Id = 1,
                                            Quantity  = 1,
                                             Translations = new List<TranslatedDosingFrequencyReminder>{
                                           {
                                                new TranslatedDosingFrequencyReminder { Title = "AutoCrated", Description = "AutoCreated"}
                                           } }
                                       }
                                   }}
                               }
                           }
                       }
                    }
                });

            await context.SaveChagesAsync();

            var dosageRecomendation = await context.DosageRecommendations.FindAsync(1);

            context.Reminders.Add(new Reminder
            {
                UserId = userId,
                Title = "Morning Reminder",
                TimeInUtc = "07:20",
                DosageRecommendations = { dosageRecomendation }
            });

            context.Reminders.Add(new Reminder { UserId = userId, Title = "Evning Reminder", TimeInUtc = "07:20" });


            context.DosageLogs.Add(new DosageLog
            {
                UserId = userId,
                Quantity = 1,
                DosageRecommendation = dosageRecomendation,
                DateTime = new DateTime(1900, 1, 1, 7, 20, 0, 0)
            });


            await context.SaveChagesAsync();
            context.ChangeTracker.Clear();

            DateTime firstData = new(1900, 1, 3, 7, 20, 0, 0);

            var lang = Language.en;

            var therapy = context.Reminders
                      .Where(
                          reminder => reminder.TimeInUtc == firstData.ToString("HH:mm") && reminder.UserId == userId
                           &&
                         (
                          reminder.DosageRecommendations.Any(x => x.DosageLogs == null)
                              ||
                          reminder.DosageRecommendations.Any(x => x.DosageLogs.Any(
                              y => y.DateTime.AddDays(y.DosageRecommendation.DosingFrequency.IntervalInDays) <= firstData
                          )))
                      )
                      .Include(reminder => reminder.DosageRecommendations)
                          .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
                      .Include(reminder => reminder.DosageRecommendations)
                          .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                          .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
                      .Include(reminder => reminder.DosageRecommendations)
                          .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                          .ThenInclude(doseFrequency => doseFrequency.Course)
                          .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
                      .Include(reminder => reminder.DosageRecommendations)
                          .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                          .ThenInclude(doseFrequency => doseFrequency.Course)
                          .ThenInclude(course => course.Therapy)
                          .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
                      .Include(reminder => reminder.DosageRecommendations)
                          .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                          .ThenInclude(doseFrequency => doseFrequency.Drug)
                          .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
                     .Include(reminder => reminder.DosageRecommendations)
                          .ThenInclude(dosageRecomendation => dosageRecomendation.DosageLogs.Where(x => x.UserId == userId))
                          .ToList();

            var s = 1;
        }
    }
}