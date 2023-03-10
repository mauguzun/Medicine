using Medicine.Entities.Enums;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;

namespace Medicine.Web.UseCases.Dto
{
    public  class TherapyDto : TransatedEntityWithDescriptionDto
    {
        public int UserId { get; set; }
        public List<CourseDto> Courses { get; set; } = new List<CourseDto>();
        public TherapyStatus Status { get; set; } = TherapyStatus.None;
        public TherapyType Type { get; set; } = TherapyType.None;
    
    }
}
