namespace Medicine.Entities.Models.Base
{
    public abstract class EntityTitleDescription : EntityAuthor
    {
        public string? Title { get; set; }
        public string? Descrptioin { get; set; }
    }
}
