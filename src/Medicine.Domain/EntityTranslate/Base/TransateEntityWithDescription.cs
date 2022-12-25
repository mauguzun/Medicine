using Medicine.Domain.EntityTranslate.Base;

namespace Medicine.Domain.Entities.Base
{
    public class TransateEntityWithDescription : TransateEntity
    {
        public string Title { get; set; }
        public string Descrptioin { get; set; }
    }
}
