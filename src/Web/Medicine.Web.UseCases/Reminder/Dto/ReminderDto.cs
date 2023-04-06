using Medicine.Entities.Models;
using Medicine.Web.UseCases.Dto;

namespace Medicine.Web.UseCases.Reminder.Dto
{
    public class ReminderDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Descrptioin { get; set; }
        public string TimeInUtc { get; set; } = "00:00";
        public List<DosageRecommendationDto>? DosageRecommendations { get; set; }
    }

}