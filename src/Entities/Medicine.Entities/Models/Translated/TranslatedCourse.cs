﻿using Medicine.Entities.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedCourse))]
    public class TranslatedCourse : TransatedEntityWithDescription
    {
        [ForeignKey("Id")]
        public int CourseId { get; set; }
        Course Course { get; set; }
        public string? Version { get; set; }
    }
}