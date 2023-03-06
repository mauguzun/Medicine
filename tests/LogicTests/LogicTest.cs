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
        public async Task ReminderSelector()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");

            var context = new AppDbContext(optionsBuilder.Options);

            int userId = 1;

            context.Drugs.Add(new Drug
            {
                Id = userId,
                OneUnitSizeInGramm = 11.22,
                TranslatedDrugs =
                {
                     new TranslatedDrugs {    Title = "Drug Name", Descrptioin = "Drug Descrption" },
                     new TranslatedDrugs {    Title = "Drug Name", Descrptioin = "Drug Descrption", Language = Language.en }
                },
                Recomendation = "use before eat 15 min",
                Title = "Citramonium"
            });

            await context.SaveChagesAsync();

            context.Therapies.Add(
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
                                    Drug =  context.Drugs.Single(),
                                    IntervalInDays = 2,
                                    DosageRecommendations =
                                   {
                                       new DosageRecommendation{
                                            Id = 1,
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

            await context.SaveChagesAsync();

            var dosageRecomendation = await context.DosageRecommendations.FindAsync(1);

            context.Reminders.Add(new Reminder
            {
                CreatedBy = userId,
                Title = "Morning Reminder",
                TimeInUtc = "07:20",
                DosageRecommendations = { dosageRecomendation }
            });

            context.Reminders.Add(new Reminder { CreatedBy = userId, Title = "Evning Reminder", TimeInUtc = "07:20" });


            context.DosageLogs.Add(new DosageLog
            {
                CreatedBy = userId,
                Quantity = 1,
                DosageRecommendation = dosageRecomendation,
                DateTime = new DateTime(1900, 1, 1, 7, 20, 0, 0)
            });


            await context.SaveChagesAsync();
            context.ChangeTracker.Clear();

            DateTime firstData = new DateTime(1900, 1, 3, 7, 20, 0, 0);

            var remider = context.Reminders
                .Where(
                    reminder => reminder.TimeInUtc == firstData.ToString("HH:mm")
                    &&
                   (
                    reminder.DosageRecommendations.Any(x=>x.DosageLogs == null) 
                        ||
                    reminder.DosageRecommendations.Any(x => x.DosageLogs.Any(y =>  (firstData - y.DateTime).Days >= 
                       y.DosageRecommendation.DosingFrequency.IntervalInDays 
                    )) )
                )
                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Course)
                    .ThenInclude(course => course.Therapy)
                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Drug)
                    .ThenInclude(dose => dose.TranslatedDrugs)
               .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosageLogs.Where(x=>x.CreatedBy == userId))
                .ToList();



        }
    }
}