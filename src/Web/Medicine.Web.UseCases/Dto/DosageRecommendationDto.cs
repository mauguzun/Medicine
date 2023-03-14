using Medicine.Entities.Models;

namespace Medicine.Web.UseCases.Dto
{
    public class DosageRecommendationDto : TransatedEntityWithDescriptionDto
    {
        public double Quantity { get; set; }
        public DosingFrequencyDto DosingFrequency { get; set; }
        public List<DosageLog> DosageLogs { get; set; }
    }
}
