using Medicine.Domain.Entities.Base;
using Medicine.Domain.Enums;

namespace Medicine.Domain.Entities
{
    public class CourseSettings :Entity
    {
        public Sex Sex { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public int Weight { get; set; }

    }
}