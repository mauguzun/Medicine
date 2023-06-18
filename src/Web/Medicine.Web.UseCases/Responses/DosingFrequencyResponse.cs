using Medicine.Application.Interfaces;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.DataLoaders.BaseDataLoader;
using Medicine.Web.UseCases.DataLoaders.TranslateDataLoader;
using Medicine.Web.UseCases.Responses.Translates;

namespace Medicine.Web.UseCases.Responses
{

    public class DosingFrequencyResponse : Entity
    {
        public int CourseId { get; set; }

        public  async Task<IEnumerable<TranslatedResponse>> Translations(ITranslateResponseLoader<int,
            TranslatedDosingFrequency, TranslatedResponse> dataLoader,
            CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.DosingFrequencyId == Id );
            return entities;
        }

        public async Task<CourseResponse> Course(IResponseLoader<int, Course, CourseResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.Id == CourseId);
            return entities?.FirstOrDefault();
        }

        public int DrugId { get; set; }

        public async Task<DrugResponse> Drug(IResponseLoader<int, Drug, DrugResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.Id == DrugId);
            return entities?.FirstOrDefault();
        }

        public double Total { get; set; }
        public int IntervalInDays { get; set; }

        public async Task<IEnumerable<DosingFrequencyReminderResponse>> DosageRecommendations(IResponseLoader<int, DosingFrequencyReminder, DosingFrequencyReminderResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.Id == DrugId);
            return entities;
        }

    }
}