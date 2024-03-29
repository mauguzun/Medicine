using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Courses;
using Medicine.Entities.Models.Dosages;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.DataLoaders.DataLoader;
using Medicine.Web.UseCases.DataLoaders.TranslateDataLoader;
using Medicine.Web.UseCases.Models.GraphqlResponse.Base.Translates;
using Medicine.Web.UseCases.Models.GraphqlResponse.Dosage;
using Medicine.Web.UseCases.Models.GraphqlResponse.Therapy;

namespace Medicine.Web.UseCases.Models.GraphqlResponse.Course
{
    public class CourseResponse : Entity
    {
        public int TherapyId { get; set; }

        public int CourseGroupId { get; set; }

        public async Task<TherapyResponse> Therapy(IResponseLoader<int, Entities.Models.Therapies.Therapy, TherapyResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.Id == TherapyId);
            return entities.FirstOrDefault();
        }

        public async Task<CourseGroupResponse> CourseGroup(IResponseLoader<int, CourseGroup, CourseGroupResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.Id == CourseGroupId);
            return entities?.FirstOrDefault();
        }
        public CourseType CourseType { get; set; } = CourseType.None;


        public async Task<IEnumerable<CourseSettingsResponse>>
                  CourseSettings(IResponseLoader<int, CourseSettings, CourseSettingsResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.CourseId == Id);
            return entities;
        }


        public async Task<IEnumerable<DosingFrequencyResponse>>
                  DosingFrequencies(IResponseLoader<int, DosingFrequency, DosingFrequencyResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.CourseId == Id);
            return entities;
        }

        public async Task<IEnumerable<TranslatedResponse>> Translations(ITranslateResponseLoader<int,
          TranslatedCourse, TranslatedResponse> dataLoader,
          CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.CourseId == Id);
            return entities;
        }


    }
}
