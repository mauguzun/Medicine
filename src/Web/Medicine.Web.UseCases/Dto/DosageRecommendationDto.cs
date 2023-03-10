using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine.Web.UseCases.Dto
{
    public class DosageRecommendationDto : TransatedEntityWithDescriptionDto
    {
        public double Quantity { get; set; }
        public DosingFrequencyDto DosingFrequency { get; set; }
        public List<DosageLog> DosageLogs { get; set; }
    }
}
