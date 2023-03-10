using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models;

namespace Medicine.Web.UseCases.Dto
{
    public class DrugDto : TransatedEntityWithDescriptionDto
    {
        public string? Recomendation { get; set; }
        public string? Title { get; set; }
        public double OneUnitSizeInGramm { get; set; }
        public List<DrugCategory> DrugCategory { get; set; } = new List<DrugCategory>();
        public List<Drug> SimilarPreparate { get; set; } = new List<Drug>();
        public List<ActiveElement> ActiveElements { get; set; } = new List<ActiveElement>();
    }
}
