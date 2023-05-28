using Medicine.Entities.Enums;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Web.UseCases.Responses.BaseDataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class TherapyResponse : EntityWithDescription
    {
        public int UserId { get; set; }
        public TherapyStatus Status { get; set; } = TherapyStatus.None;
        public TherapyType Type { get; set; } = TherapyType.None;

        public async Task<IEnumerable<CourseResponse>>
            Courses(IResponseLoader<int, Course, CourseResponse> dataLoader, CancellationToken ct)
        {

            var courses = await dataLoader.LoadAsync(x => x.CourseGroup?.Id == Id);
            return courses;
        }
    }
}
