using Medicine.Domain.Entities.Base;
using Medicine.Domain.Enums;

namespace Medicine.Domain.Entities
{
    public class Therapy : EntityWithDescriptionEntityTransate
    {
        public List<Course>? Courses { get; set; }
        public TherapyStatus Status { get; set; }
        public TherapyType Type { get; set; }

    }
}
