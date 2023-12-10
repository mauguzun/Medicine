namespace Medicine.Entities.Models.Base
{
    public abstract class EntityTitleDescription : EntityUser
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
