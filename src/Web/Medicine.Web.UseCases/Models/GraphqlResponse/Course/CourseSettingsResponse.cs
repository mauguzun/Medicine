using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;

namespace Medicine.Web.UseCases.Models.GraphqlResponse.Course
{
    public class CourseSettingsResponse : EntityUser
    {
        public int CourseId { get; set; }
        public Medicine.Entities.Models.Courses.Course Course { get; set; }
        public Sex Sex { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public int Weight { get; set; }

    }
}
