using Medicine.Entities.Models;
using Medicine.Entities.Models.Translated.Base;
using Medicine.Web.UseCases.DataLoaders.DataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class CourseGroupDto : TransatedEntityWithDescription
    {
        public async Task<IEnumerable<CourseDto>>
            Courses(IResponseLoader<int, Course, CourseDto> dataLoader, CancellationToken ct)
        {

            var courses = await dataLoader.LoadByCondition(x => x.CourseGroup?.Id == Id);
            return courses;
        }

    }
}
