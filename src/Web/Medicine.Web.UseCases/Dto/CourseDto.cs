using Medicine.Entities.Enums;
using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models;

namespace Medicine.Web.UseCases.Dto
{
    public  class CourseDto : TransatedEntityWithDescriptionDto
    {
        public TherapyDto? Therapy { get; set; }
        public List<CourseSettings> CourseSettings { get; set; } 
        public CourseType CourseType { get; set; } = CourseType.None;
        public CourseGroup? CourseGroup { get; set; } 
        public List<DosingFrequencyDto> DosingFrequencies { get; set; } 
        public string? Version { get; set; }
    }
}