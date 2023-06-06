using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Base.Interfaces;

namespace Medicine.Entities.Models.Translated.Base
{
    public abstract class TransatedEntity :  EntityAuthor , ITransatedEntity
    {
        public Language Language { get; set; }
    }
}