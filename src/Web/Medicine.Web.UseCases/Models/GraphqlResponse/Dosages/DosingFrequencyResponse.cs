using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Dosages;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.DataLoaders.DataLoader;
using Medicine.Web.UseCases.DataLoaders.TranslateDataLoader;
using Medicine.Web.UseCases.Models.GraphqlResponse.Base.Translates;
using Medicine.Web.UseCases.Models.GraphqlResponse.Course;
using Medicine.Web.UseCases.Models.GraphqlResponse.Drug;

namespace Medicine.Web.UseCases.Models.GraphqlResponse.Dosage
{

    public class DosingFrequencyResponse : Entity
    {
        public int CourseId { get; set; }

        public async Task<IEnumerable<TranslatedResponse>> Translations(ITranslateResponseLoader<int,
            TranslatedDosingFrequency, TranslatedResponse> dataLoader,
            CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.DosingFrequencyId == Id);
            return entities;
        }

        public async Task<CourseResponse> Course(IResponseLoader<int, Medicine.Entities.Models.Courses.Course, CourseResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.Id == CourseId);
            return entities?.FirstOrDefault();
        }

        public int DrugId { get; set; }

        public async Task<DrugReponse> Drug(IResponseLoader<int, Medicine.Entities.Models.Drugs.Drug, DrugReponse> dataLoader, CancellationToken ct)
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