using Medicine.Entities.Enums;

namespace Medicine.Entities.Models.Base
{
    public class TransatedEntity : EntityByUser
    {
        public Language Language { get; set; }
    }
}