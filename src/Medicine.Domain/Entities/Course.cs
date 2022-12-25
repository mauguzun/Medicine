﻿using Medicine.Domain.Entities.Base;
using Medicine.Domain.Enums;

namespace Medicine.Domain.Entities
{
    public class Course : EntityWithDescriptionEntityTransate
    {
        public Therapy? Therapy { get; set; }
        public CourseSettings? CourseSettings { get; set; }
        public CourseType CourseType { get; set; }
        public List<DosingFrequency>? DosingFrequencies { get; set; }
        public List<Course> CourseGroup { get; set; }
        public string? Version { get; set; }
    }
}