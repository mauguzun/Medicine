using Medicine.Entities.Enums;

namespace Medicine.Entities.Models.Base.Interfaces
{
    public interface ITransatedEntity : IEntity
    {
        public Language Language { get; set; }
    }
}