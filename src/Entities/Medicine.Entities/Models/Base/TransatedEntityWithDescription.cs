namespace Medicine.Entities.Models.Base
{
    public abstract class TransatedEntityWithDescription : TransatedEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

}
