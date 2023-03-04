using Medicine.DataAccess.Sql;
using Medicine.Entities.Enums;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Translated;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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


            context.Therapies.Add(
               new Therapy
               {
                   CreatedBy = Guid.NewGuid(),
                   Type = TherapyType.AutoCreated,
                   Status = TherapyStatus.Statret,
                   TranslatedTherapies = {
                       new TranslatedTherapy
                       {
                           Title = "AutoCrated",
                           Descrptioin = "AutoCreated"
                       },
                       new TranslatedTherapy
                       {
                            Title = "AutoCrated2", Descrptioin = "AutoCreated2",Language = Language.lv

                       }
                   }
               });

            await context.SaveChagesAsync();
            context.ChangeTracker.Clear();
            //
            //var selected = Reminders
            //    .Include(x => x.DosageRecommendations)
            //    .ThenInclude(x => x.DosingFrequency)
            //    .ThenInclude(x => x.Course)
            //    .ThenInclude(x => x.Therapy)
            //    .Where(x => x.Time == time);



            var therapy = await context.Therapies.Include(x => x.TranslatedTherapies.Where(y => y.Language == Language.en)).FirstAsync();
            Assert.AreEqual(therapy.TranslatedTherapies.FirstOrDefault().Title, "AutoCrated");
        }
    }
}