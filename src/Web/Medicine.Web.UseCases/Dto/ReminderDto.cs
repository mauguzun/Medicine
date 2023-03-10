using Medicine.Entities.Models;

namespace Medicine.Web.UseCases.Dto
{
    public class ReminderDto : TransatedEntityWithDescriptionDto
    {
        public string TimeInUtc { get; set; } = "00:00";
        public List<DosageRecommendationDto> DosageRecommendations { get; set; } = new List<DosageRecommendationDto>();
    }
 
}