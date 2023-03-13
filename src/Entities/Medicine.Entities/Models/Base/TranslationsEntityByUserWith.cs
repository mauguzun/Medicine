namespace Medicine.Entities.Models.Base
{
    public abstract class TranslationsEntityByUserWith<T> : EntityByUser
    {
        public virtual List<T> Translations { get; set; }
    }
}
