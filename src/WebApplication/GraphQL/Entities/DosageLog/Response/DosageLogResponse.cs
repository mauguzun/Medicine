using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models;
using Medicine.WebApplication.GraphQL.Entities.DosageRecommendations.Response;


namespace Medicine.WebApplication.GraphQL.Entities.DosageLog.Response
{
    public class DosageLogResponse : EntityByUser
    {
        public DosageRecommendationResponse DosageRecommendation { get; set; }
        public ReminderLogStatus Status { get; set; }
        public double Quantity { get; set; }
        public DateTime DateTime { get; set; }
    }
}