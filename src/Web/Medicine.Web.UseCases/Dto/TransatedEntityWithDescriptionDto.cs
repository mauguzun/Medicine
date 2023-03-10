using Medicine.Entities.Enums;

namespace Medicine.Web.UseCases.Dto
{
    public  class TransatedEntityWithDescriptionDto
    {
        public string? Title { get; set; }
        public string? Descrptioin { get; set; }
        public Language Language { get; set; }
    }
}
