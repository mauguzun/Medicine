using Medicine.Entities.Enums;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.DataLoaders.DataLoader;
using Medicine.Web.UseCases.Responses.Translates;

namespace Medicine.Web.UseCases.Responses
{
    public class TherapyDto : EntityTitleDescription
    {
        public int UserId { get; set; }
        public TherapyStatus Status { get; set; } = TherapyStatus.None;
        public TherapyType Type { get; set; } = TherapyType.None;

        public async Task<IEnumerable<CourseDto>> Courses(IResponseLoader<int, Course, CourseDto> dataLoader, CancellationToken ct)
        {
            var courses = await dataLoader.LoadByCondition(x => x.CourseGroup?.Id == Id);
            return courses;
        }

        public async Task<IEnumerable<TranslatedDto>> Translations(IResponseLoader<int, TranslatedTherapy, TranslatedDto> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.TherapyId == Id);
            return entities;
        }
    }
}
