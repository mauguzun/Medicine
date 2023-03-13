namespace Medicine.Entities.Models.Base
{
    public abstract class EntityWithDescription : EntityByUser
    {
        public string? Title { get; set; }
        public string? Descrptioin { get; set; }
    }
}
