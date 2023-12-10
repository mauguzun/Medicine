using Medicine.Entities.Models;
using Medicine.Entities.Models.Translated.Base;
using Medicine.Web.UseCases.DataLoaders.DataLoader;

namespace Medicine.Web.UseCases.Models.GraphqlResponse.Course
{
    public class CourseGroupResponse : TransatedEntityWithDescription
    {
        public async Task<IEnumerable<CourseResponse>>
            Courses(IResponseLoader<int, Medicine.Entities.Models.Courses.Course, CourseResponse> dataLoader, CancellationToken ct)
        {

            var courses = await dataLoader.LoadByCondition(x => x.CourseGroup?.Id == Id);
            return courses;
        }

    }
}
