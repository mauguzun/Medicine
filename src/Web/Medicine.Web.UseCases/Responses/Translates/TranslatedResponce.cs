using Medicine.Entities.Models.Translated.Base;

namespace Medicine.Web.UseCases.Responses.Translates
{
    public class TranslatedResponse : TransatedEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
