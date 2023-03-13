﻿using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models
{
    public class DosageRecommendation : TranslationsEntityByUserWith<TranslatedDosageRecommendation>
    {
        public double Quantity { get; set; }

        public DosingFrequency DosingFrequency { get; set; }
        public List<DosageLog> DosageLogs { get; set; } = new List<DosageLog>();
    }
}
