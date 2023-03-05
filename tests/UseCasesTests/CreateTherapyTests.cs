using Medicine.DataAccess.Sql;
using Medicine.Entities.Enums;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Translated;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq.Expressions;

namespace UseCasesTests
{
    public class CreateTherapyTests
    {


        [Test]
        public async Task TherapyTests()
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
                Time = TimeOnly.Parse("07:20"),
                DosageRecommendations = { dosageRecomendation }
            });

            context.Reminders.Add(new Reminder { CreatedBy = userId, Title = "Evning Reminder", Time = TimeOnly.Parse("20:20") });

            context.ChangeTracker.Clear();


            DateTime firstData = new DateTime(1900, 1, 1, 7, 20, 0, 0);





            //var therapy = await context.Therapies.Include(x => x.TranslatedTherapies.Where(y => y.Language == Language.en)).FirstAsync();
            //Assert.AreEqual(therapy.TranslatedTherapies.FirstOrDefault().Title, "AutoCrated");
        }
    }
}