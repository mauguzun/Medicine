using Medicine.Entities.Enums;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.DataLoaders.BaseDataLoader;
using Medicine.Web.UseCases.Responses.Translates;

namespace Medicine.Web.UseCases.Responses
{
    public class TherapyResponse : EntityTitleDescription
    {
        public int UserId { get; set; }
        public TherapyStatus Status { get; set; } = TherapyStatus.None;
        public TherapyType Type { get; set; } = TherapyType.None;

        public async Task<IEnumerable<CourseResponse>> Courses(IResponseLoader<int, Course, CourseResponse> dataLoader, CancellationToken ct)
        {
            var courses = await dataLoader.LoadAsync(x => x.CourseGroup?.Id == Id);
            return courses;
        }

        public async Task<IEnumerable<TranslatedResponse>> Translations(IResponseLoader<int, TranslatedTherapy, TranslatedResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadAsync(x => x.TherapyId == Id);
            return entities;
        }
    }
}
