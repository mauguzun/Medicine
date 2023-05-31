using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models;
using Medicine.Web.UseCases.Responses.BaseDataLoader;
using Medicine.Entities.Models.Base;

namespace Medicine.Web.UseCases.Responses
{

    public class DosingFrequencyResponse : Entity
    { 
        public int CourseId { get; set; }

        public  async Task<IEnumerable<TranslatedDosingFrequency>> Translations(IResponseLoader<int,
            TranslatedDosingFrequency, TranslatedResponse> dataLoader,
            CancellationToken ct)
        {
            var entities = await dataLoader.LoadAsync(x => x.DosingFrequency.Id == Id);
            return new IEnumerable<TranslatedDosingFrequency>()
        }

        public async Task<CourseResponse> Course(IResponseLoader<int, Course, CourseResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadAsync(x => x.Id == CourseId);
            return entities?.FirstOrDefault();
        }

        public int DrugId { get; set; }

        public async Task<DrugResponse> Drug(IResponseLoader<int, Drug, DrugResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadAsync(x => x.Id == DrugId);
            return entities?.FirstOrDefault();
        }

        public double Total { get; set; }
        public int IntervalInDays { get; set; }

        public async Task<IEnumerable<DosingFrequencyReminderResponse>> DosageRecommendations(IResponseLoader<int, DosingFrequencyReminder, DosingFrequencyReminderResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadAsync(x => x.Id == DrugId);
            return entities;
        }

    }
}