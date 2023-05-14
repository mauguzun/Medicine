using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models;


namespace Medicine.WebApplication.GraphQL.Entities.DosingFrequency.Response
{

    public class DosingFrequencyResponse : TranslationsEntityByUserWith<TranslatedDosingFrequency>
    {
        public Course Course { get; set; }

        public Drug Drug { get; set; }

        public int DrugId { get; set; }

        public double Total { get; set; }
        public int IntervalInDays { get; set; } = 1;

        public List<DosageRecommendation> DosageRecommendations { get; set; } = new List<DosageRecommendation>();

    }
}