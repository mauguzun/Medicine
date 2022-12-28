﻿using Medicine.Domain.Entities.Base;

namespace Medicine.Domain.Entities
{
    public class DosingFrequency : Entity
    {
        public Course Course { get; set; }
        public Drug Drug { get; set; }

        public List<DosageRecommendation>? DosageRecommendation { get; set; } 
        public double Total { get; set; }
        public int IntervalInDays { get; set; } = 1;


        public List<TranslatedDosingFrequency> TranslatedDosingFrequency { get; set; }
    }
}