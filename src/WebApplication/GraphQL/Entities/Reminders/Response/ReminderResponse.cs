using Medicine.Entities.Models.Base;
using Medicine.Entities.Models;
using Medicine.WebApplication.GraphQL.DataLoaders;
using Medicine.WebApplication.GraphQL.Entities.Reminders.Response;

namespace Medicine.WebApplication.GraphQL.Reminders.Response
{
    public class ReminderResponse : EntityWithDescription
    {
        public string TimeInUtc { get; set; } = "00:00";

        public async Task<IEnumerable<DosageRecommendationResponse>>
            DosageRecommendations(IResponseLoader<int, DosageRecommendation, DosageRecommendationResponse> dataLoader, CancellationToken ct)
        {

            var dosageRecommendation = await dataLoader.LoadAsync(new List<int> { 1 }, ct);
            return dosageRecommendation;
        }
    }
}
