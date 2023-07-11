using Medicine.Entities.Models;
using Medicine.Entities.Models.Base.Interfaces;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.DataLoaders.DataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class DosingFrequencyReminderDto : TranslationEntity<TranslatedDosingFrequencyReminder>
    {
        public double Quantity { get; set; }
        public string UsingDescription { get; set; }

        public int ReminderId { get; set; }

        public int DosingFrequencyId { get; set; }

        public async Task<DosingFrequencyDto>
            DosingFrequency(IResponseLoader<int, DosingFrequency, DosingFrequencyDto> dataLoader, CancellationToken ct)
        {
            var dosingFrequency = await dataLoader.LoadByCondition(x => x.Id == DosingFrequencyId);
            return dosingFrequency?.FirstOrDefault();
        }


        public async Task<IEnumerable<DosageLogDto>>
            DosageLogs(IResponseLoader<int, DosageLog, DosageLogDto> dataLoader, CancellationToken ct)
        {
            var dosageLogs = await dataLoader.LoadByCondition(x => x.DosageRecommendationId == Id);
            return dosageLogs;
        }

    }
}
