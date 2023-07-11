using Medicine.Entities.Enums;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.DataLoaders.DataLoader;
using Medicine.Web.UseCases.DataLoaders.TranslateDataLoader;
using Medicine.Web.UseCases.Responses.Translates;

namespace Medicine.Web.UseCases.Responses
{
    public class CourseDto : Entity
    {
        public int TherapyId { get; set; }

        public int CourseGroupId { get; set; }

        public async Task<TherapyDto> Therapy(IResponseLoader<int, Therapy, TherapyDto> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.Id == TherapyId);
            return entities.FirstOrDefault();
        }

        public async Task<CourseGroupDto> CourseGroup(IResponseLoader<int, CourseGroup, CourseGroupDto> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.Id == CourseGroupId);
            return entities?.FirstOrDefault();
        }
        public CourseType CourseType { get; set; } = CourseType.None;


        public async Task<IEnumerable<CourseSettingsDto>>
                  CourseSettings(IResponseLoader<int, CourseSettings, CourseSettingsDto> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.CourseId == Id);
            return entities;
        }


        public async Task<IEnumerable<DosingFrequencyDto>>
                  DosingFrequencies(IResponseLoader<int, DosingFrequency, DosingFrequencyDto> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.CourseId == Id);
            return entities;
        }

        public async Task<IEnumerable<TranslatedDto>> Translations(ITranslateResponseLoader<int,
          TranslatedCourse, TranslatedDto> dataLoader,
          CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.CourseId == Id);
            return entities;
        }


    }
}
