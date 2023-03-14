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
        public CourseDto Course { get; set; }
        public DrugDto? Drug { get; set; }

        public double Total { get; set; }
        public int IntervalInDays { get; set; } = 1;

        public List<DosageRecommendationDto> DosageRecommendations { get; set; }
        public List<TranslatedDosingFrequency> TranslatedDosingFrequency { get; set; } 
    }
}
