using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    public class DosingFrequency : Entity
    {
        public Course Course { get; set; }
        public Drug Drug { get; set; }

        public List<DosageRecommendation>? DosageRecommendation { get; set; }
        public double Total { get; set; }
        public int IntervalInDays { get; set; } = 1;

        public TranslatedDosingFrequency TranslatedDosingFrequency { get; set; }
    }
}