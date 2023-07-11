using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Web.UseCases.DataLoaders.DataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class DosageLogDto : EntityAuthor
    {
        public Entities.Enums.DosageLogStatus Status { get; set; }
        public double Quantity { get; set; }
        public DateTime DateTime { get; set; }
        public int DosageRecommendationId { get; set; }


        public async Task<DosingFrequencyReminderDto>
          DosageRecommendation(IResponseLoader<int, DosingFrequencyReminder, DosingFrequencyReminderDto> dataLoader, CancellationToken ct)
        {
            var dosageRecommendation = await dataLoader.LoadByCondition(x => x.Id == DosageRecommendationId);
            return  dosageRecommendation?.FirstOrDefault();
        }
    }
}