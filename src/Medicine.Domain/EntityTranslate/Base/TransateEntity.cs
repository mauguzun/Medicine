using Medicine.Domain.Enums;

namespace Medicine.Domain.EntityTranslate.Base
{
    public class TransateEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Language Language { get; set; }
    }
}