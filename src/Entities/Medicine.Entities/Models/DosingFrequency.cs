using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    public class DosingFrequency : EntityByUser
    {
        public Course Course { get; set; }
        public Drug  Drug { get; set; }

        public double Total { get; set; }
        public int IntervalInDays { get; set; } = 1;

        public List<DosageRecommendation> DosageRecommendations { get; set; } = new List<DosageRecommendation>();

        public List<TranslatedDosingFrequency>  TranslatedDosingFrequency { get; set; } = new List<TranslatedDosingFrequency>();
  

    }
}