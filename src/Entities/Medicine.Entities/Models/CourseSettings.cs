using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    public class CourseSettings : EntityAuthor
    {
        public int  CourseId  { get; set; }
        public Course Course  { get; set; }
        public Sex Sex { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public int Weight { get; set; }

    }
}