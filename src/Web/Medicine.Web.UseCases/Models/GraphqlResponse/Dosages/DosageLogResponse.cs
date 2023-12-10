using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Dosages;
using Medicine.Web.UseCases.DataLoaders.DataLoader;

namespace Medicine.Web.UseCases.Models.GraphqlResponse.Dosage
{
    public class DosageLogResponse : EntityUser
    {
        public Entities.Enums.DosageLogStatus Status { get; set; }
        public double Quantity { get; set; }
        public DateTime DateTime { get; set; }
        public int DosageRecommendationId { get; set; }


        public async Task<DosingFrequencyReminderResponse>
          DosageRecommendation(IResponseLoader<int, DosingFrequencyReminder, DosingFrequencyReminderResponse> dataLoader, CancellationToken ct)
        {
            var dosageRecommendation = await dataLoader.LoadByCondition(x => x.Id == DosageRecommendationId);
            return dosageRecommendation?.FirstOrDefault();
        }
    }
}