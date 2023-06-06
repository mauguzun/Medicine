using Medicine.Entities.Models.Base;
using Medicine.Entities.Models;
using Medicine.Web.UseCases.DataLoaders.BaseDataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class ReminderResponse : EntityTitleDescription
    {
        public string TimeInUtc { get; set; } = "00:00";

        public async Task<IEnumerable<DosingFrequencyReminderResponse>>
            DosingFrequencyReminders(IResponseLoader<int, DosingFrequencyReminder, DosingFrequencyReminderResponse> dataLoader, CancellationToken ct)
        {

            var dosageRecommendation = await dataLoader.LoadAsync(x => x.ReminderId == Id);
            return dosageRecommendation;
        }
    }
}
