using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models;
using Medicine.Web.UseCases.DataLoaders.BaseDataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class DosageLogResponse : EntityAuthor
    {
        public Entities.Enums.DosageLogStatus Status { get; set; }
        public double Quantity { get; set; }
        public DateTime DateTime { get; set; }
        public int DosageRecommendationId { get; set; }


        public async Task<DosingFrequencyReminderResponse>
          DosageRecommendation(IResponseLoader<int, DosingFrequencyReminder, DosingFrequencyReminderResponse> dataLoader, CancellationToken ct)
        {
            var dosageRecommendation = await dataLoader.LoadByCondition(x => x.Id == DosageRecommendationId);
            return  dosageRecommendation?.FirstOrDefault();
        }
    }
}