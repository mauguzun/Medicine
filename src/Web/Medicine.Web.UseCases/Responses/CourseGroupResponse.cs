using Medicine.Entities.Models;
using Medicine.Entities.Models.Translated.Base;
using Medicine.Web.UseCases.Responses.BaseDataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class CourseGroupResponse : TransatedEntityWithDescription
    {
        public async Task<IEnumerable<CourseResponse>>
            Courses(IResponseLoader<int, Course, CourseResponse> dataLoader, CancellationToken ct)
        {

            var courses = await dataLoader.LoadAsync(x => x.CourseGroup?.Id == Id);
            return courses;
        }

    }
}
