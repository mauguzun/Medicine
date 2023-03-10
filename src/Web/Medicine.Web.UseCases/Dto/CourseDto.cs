using Medicine.Entities.Enums;
using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models;

namespace Medicine.Web.UseCases.Dto
{
    public  class CourseDto : TransatedEntityWithDescriptionDto
    {
        public Therapy? Therapy { get; set; }
        public CourseSettings CourseSettings { get; set; }
        public CourseType CourseType { get; set; } = CourseType.None;

        public List<DosingFrequency> DosingFrequencies { get; set; } = new List<DosingFrequency>();
        public List<Course> CourseGroup { get; set; } = new List<Course>();
        public string? Version { get; set; }
    }
}