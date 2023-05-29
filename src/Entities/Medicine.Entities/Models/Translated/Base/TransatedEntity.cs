using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models.Translated.Base
{
    public abstract class TransatedEntity : EntityAuthor
    {
        public Language Language { get; set; }
    }
}