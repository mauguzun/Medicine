using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.DataLoaders.DataLoader;
using Medicine.Web.UseCases.DataLoaders.TranslateDataLoader;
using Medicine.Web.UseCases.Responses.Translates;

namespace Medicine.Web.UseCases.Responses
{

    public class DosingFrequencyDto : Entity
    {
        public int CourseId { get; set; }

        public  async Task<IEnumerable<TranslatedDto>> Translations(ITranslateResponseLoader<int,
            TranslatedDosingFrequency, TranslatedDto> dataLoader,
            CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.DosingFrequencyId == Id );
            return entities;
        }

        public async Task<CourseDto> Course(IResponseLoader<int, Course, CourseDto> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.Id == CourseId);
            return entities?.FirstOrDefault();
        }

        public int DrugId { get; set; }

        public async Task<DrugDto> Drug(IResponseLoader<int, Drug, DrugDto> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.Id == DrugId);
            return entities?.FirstOrDefault();
        }

        public double Total { get; set; }
        public int IntervalInDays { get; set; }

        public async Task<IEnumerable<DosingFrequencyReminderDto>> DosageRecommendations(IResponseLoader<int, DosingFrequencyReminder, DosingFrequencyReminderDto> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.Id == DrugId);
            return entities;
        }

    }
}