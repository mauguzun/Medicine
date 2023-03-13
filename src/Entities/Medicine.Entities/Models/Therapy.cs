﻿using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    public class Therapy : TranslationsEntityByUserWith<TranslatedTherapy>
    {
        public int UserId { get; set; }
        public TherapyStatus Status { get; set; } = TherapyStatus.None;
        public TherapyType Type { get; set; } = TherapyType.None;

        public List<Course> Courses { get; set; } = new List<Course>();

    }
}
