using Medicine.Entities.Models.Base;
using Medicine.Entities.Models;
using Medicine.Web.UseCases.Responses.BaseDataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class ReminderResponse : EntityWithDescription
    {
        public string TimeInUtc { get; set; } = "00:00";

        public async Task<IEnumerable<DosageRecommendationResponse>>
            DosageRecommendations(IResponseLoader<int, DosingFrequencyReminder, DosageRecommendationResponse> dataLoader, CancellationToken ct)
        {

            var dosageRecommendation = await dataLoader.LoadAsync(x => x.ReminderId == Id);
            return dosageRecommendation;
        }
    }
}
