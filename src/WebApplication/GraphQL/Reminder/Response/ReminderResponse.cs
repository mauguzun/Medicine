using Medicine.Entities.Models.Base;
using Medicine.Entities.Models;
using Medicine.WebApplication.GraphQL.DataLoaders;


namespace Medicine.WebApplication.GraphQL.Reminder.Response
{
    public class ReminderResponse : EntityWithDescription
    {
        public string TimeInUtc { get; set; } = "00:00";

        // tut mne nada evo tozhe v responce peredlivat , kak ja ponumaju 
        public async Task<IEnumerable<DosageRecommendation>>
            DosageRecommendations(DataLoader<DosageRecommendation, 
             DosageRecommendation> dataLoader, CancellationToken ct)
        {
            // mne tut nado takoj zapros ,mozhet kakoj ta delegat ?
            // await _dbContext.Set<DosageRecommendation>().Where(t => t.ReminderId == Id) 
            var dosageRecommendation = await dataLoader.LoadAsync(Id, ct); 
            return new List<DosageRecommendation>() { dosageRecommendation};
        }
    }
}
