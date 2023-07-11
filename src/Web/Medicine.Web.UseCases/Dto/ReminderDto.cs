using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Web.UseCases.DataLoaders.DataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class ReminderDto : EntityTitleDescription
    {
        public string? TimeInUtc { get; set; } = "00:00";

        public async Task<IEnumerable<DosingFrequencyReminderDto>>
            DosingFrequencyReminders(IResponseLoader<int, DosingFrequencyReminder, DosingFrequencyReminderDto> dataLoader, CancellationToken ct)
        {

            var dosageRecommendation = await dataLoader.LoadByCondition(x => x.ReminderId == Id);
            return dosageRecommendation;
        }
    }
}
