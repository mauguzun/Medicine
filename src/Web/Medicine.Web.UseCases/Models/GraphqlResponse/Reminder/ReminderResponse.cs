using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Dosages;
using Medicine.Web.UseCases.DataLoaders.DataLoader;
using Medicine.Web.UseCases.Models.GraphqlResponse.Dosage;

namespace Medicine.Web.UseCases.Models.GraphqlResponse.Reminder
{
    public class ReminderResponse : EntityTitleDescription
    {
        public string? TimeInUtc { get; set; } = "00:00";

        public async Task<IEnumerable<DosingFrequencyReminderResponse>>
            DosingFrequencyReminders(IResponseLoader<int, DosingFrequencyReminder, DosingFrequencyReminderResponse> dataLoader, CancellationToken ct)
        {

            var dosageRecommendation = await dataLoader.LoadByCondition(x => x.ReminderId == Id);
            return dosageRecommendation;
        }
    }
}
