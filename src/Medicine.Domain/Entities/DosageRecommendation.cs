using Medicine.Domain.Entities.Base;

namespace Medicine.Domain.Entities
{
    public class DosageRecommendation : EntityWithDescriptionEntityTransate
    {
        public double Total { get; set; }
        public DosingFrequency DosingFrequency { get; set; }
    }
}
