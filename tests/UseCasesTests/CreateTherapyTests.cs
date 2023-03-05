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
        



            //var therapy = await context.Therapies.Include(x => x.TranslatedTherapies.Where(y => y.Language == Language.en)).FirstAsync();
            //Assert.AreEqual(therapy.TranslatedTherapies.FirstOrDefault().Title, "AutoCrated");
        }
    }
}