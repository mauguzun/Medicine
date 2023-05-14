using Medicine.Entities.Models.Base;
using Medicine.Entities.Models;
using Medicine.WebApplication.GraphQL.Entities.DosageRecommendations.Response;
using Medicine.WebApplication.GraphQL.BaseDataLoader;

namespace Medicine.WebApplication.GraphQL.Entities.Reminders.Response
{
    public class ReminderResponse : EntityWithDescription
    {
        public string TimeInUtc { get; set; } = "00:00";

        public async Task<IEnumerable<DosageRecommendationResponse>>
            DosageRecommendations(IResponseLoader<int, DosageRecommendation, DosageRecommendationResponse> dataLoader, CancellationToken ct)
        {

            var dosageRecommendation = await dataLoader.LoadAsync(x => x.ReminderId == Id);
            return dosageRecommendation;
        }
    }
}
