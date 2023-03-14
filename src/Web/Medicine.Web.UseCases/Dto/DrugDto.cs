using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models;

namespace Medicine.Web.UseCases.Dto
{
    public class DrugDto : TransatedEntityWithDescriptionDto
    {
        public string? Recomendation { get; set; }
        public string? Title { get; set; }
        public double OneUnitSizeInGramm { get; set; }
        public List<DrugCategoryDto> DrugCategory { get; set; } 
        public List<DrugDto> SimilarPreparate { get; set; } 
        public List<ActiveElementDto> ActiveElements { get; set; }
    }
}
