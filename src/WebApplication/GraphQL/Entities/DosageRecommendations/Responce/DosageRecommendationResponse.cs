using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.WebApplication.GraphQL.Entities.Reminders.Response
{
    public class DosageRecommendationResponse : TranslationsEntityByUserWith<TranslatedDosageRecommendation>
    {
        public double Quantity { get; set; }

        public int ReminderId { get; set; }

        public DosingFrequency? DosingFrequency { get; set; }
        public List<DosageLog>? DosageLogs { get; set; } 
    }
}
