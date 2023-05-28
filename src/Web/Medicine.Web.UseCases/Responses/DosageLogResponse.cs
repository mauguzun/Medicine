using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models;
using Medicine.Web.UseCases.Responses.BaseDataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class DosageLogResponse : EntityByUser
    {

        public ReminderLogStatus Status { get; set; }
        public double Quantity { get; set; }
        public DateTime DateTime { get; set; }
        public int DosageRecommendationId { get; set; }


        public async Task<DosageRecommendationResponse>
          DosageRecommendation(IResponseLoader<int, DosingFrequencyReminder, DosageRecommendationResponse> dataLoader, CancellationToken ct)
        {
            var dosageRecommendation = await dataLoader.LoadAsync(x => x.Id == DosageRecommendationId);
            return  dosageRecommendation?.FirstOrDefault();
        }
    }
}