using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;

namespace Medicine.Web.UseCases.Responses.Translates
{
    public class TranslatedDto : IEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Language Language { get; set; }
        public int Id { get; set; }
    }
}
