using Medicine.Entities.Models;

namespace Medicine.Web.UseCases.Dto
{
    public class DrugCategoryDto : TransatedEntityWithDescriptionDto
    {
        public int DrugId { get; set; }
        public List<DrugDto> Drugs { get; set; }
    }
}