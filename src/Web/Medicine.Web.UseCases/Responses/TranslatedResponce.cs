using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated.Base;

namespace Medicine.Web.UseCases.Responses
{
    public class TranslatedResponse : TransatedEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
