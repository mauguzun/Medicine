using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models
{
    public class DosingFrequency : EntityByUser
    {
        public Course Course { get; set; }
        public int CourseId  { get; set; }

        public Drug  Drug { get; set; }

        public int DrugId { get; set; }


        public double Total { get; set; }
        public int IntervalInDays { get; set; } = 1;

        public ICollection<DosageRecommendation> DosageRecommendations { get; set; } = new List<DosageRecommendation>();

        public ICollection<TranslatedDosingFrequency>  TranslatedDosingFrequency { get; set; } = new List<TranslatedDosingFrequency>();
  
    }
}