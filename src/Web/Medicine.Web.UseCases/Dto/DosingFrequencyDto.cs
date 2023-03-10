using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine.Web.UseCases.Dto
{
    public class DosingFrequencyDto : TransatedEntityWithDescriptionDto
    {
        public Course Course { get; set; }
        public Drug? Drug { get; set; }

        public double Total { get; set; }
        public int IntervalInDays { get; set; } = 1;

        public List<DosageRecommendation> DosageRecommendations { get; set; } = new List<DosageRecommendation>();

        public List<TranslatedDosingFrequency> TranslatedDosingFrequency { get; set; } = new List<TranslatedDosingFrequency>();

    }
}
