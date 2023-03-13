namespace Medicine.Entities.Models.Base
{
    public abstract class EntityByUser : Entity
    {
        public int CreatedBy { get; set; }
    }
}
