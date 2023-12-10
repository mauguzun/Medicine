namespace Medicine.Entities.Models.Base.Interfaces
{
    public abstract class TranslationEntity<T> : EntityUser
    {
        public virtual List<T>? Translations { get; set; }
    }
}
