using Medicine.Entities.Models.Base;

namespace Medicine.Web.UseCases.Responses
{
    public class TranslatedResponse : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
