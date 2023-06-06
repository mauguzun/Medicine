namespace Medicine.Entities.Models.Base.Interfaces
{
    public abstract class TranslationEntity<T> : EntityAuthor
    {
        public virtual List<T>? Translations { get; set; }
    }
}
