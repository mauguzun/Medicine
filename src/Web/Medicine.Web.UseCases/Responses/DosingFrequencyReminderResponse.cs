using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.Responses.BaseDataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class DosingFrequencyReminderResponse : TranslationEntity<TranslatedDosingFrequencyReminder>
    {
        public double Quantity { get; set; }
        public string UsingDescription { get; set; }

        public int ReminderId { get; set; }

        public int DosingFrequencyId { get; set; }

        public async Task<DosingFrequencyResponse>
            DosingFrequency(IResponseLoader<int, DosingFrequency, DosingFrequencyResponse> dataLoader, CancellationToken ct)
        {
            var dosingFrequency = await dataLoader.LoadAsync(x => x.Id == DosingFrequencyId);
            return dosingFrequency?.FirstOrDefault();
        }


        public async Task<IEnumerable<DosageLogResponse>>
            DosageLogs(IResponseLoader<int, DosageLog, DosageLogResponse> dataLoader, CancellationToken ct)
        {
            var dosageLogs = await dataLoader.LoadAsync(x => x.DosageRecommendationId == Id);
            return dosageLogs;
        }

    }
}
