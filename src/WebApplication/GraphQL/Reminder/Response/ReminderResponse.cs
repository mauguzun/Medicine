using Medicine.Entities.Models.Base;
using Medicine.Entities.Models;
using Medicine.WebApplication.GraphQL.DataLoaders;


namespace Medicine.WebApplication.GraphQL.Reminder.Response
{
    public class ReminderResponse : EntityWithDescription
    {
        public string TimeInUtc { get; set; } = "00:00";

        public async Task<IEnumerable<DosageRecommendation>>
            DosageRecommendations(ResponseLoader<DosageRecommendation, 
             DosageRecommendation> dataLoader, CancellationToken ct)
        {
            var dosageRecommendation = await dataLoader.LoadAsync(Id, ct); 
            return new List<DosageRecommendation>() { dosageRecommendation};
        }
    }
}
