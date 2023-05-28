using Medicine.Entities.Models.Base;
using Medicine.Entities.Models;
using Medicine.Web.UseCases.Responses.BaseDataLoader;
using Medicine.Entities.Enums;

namespace Medicine.Web.UseCases.Responses
{
    public class CourseResponse : EntityWithDescription
    {
        public int TherapyId { get; set; }
        public Therapy Therapy { get; set; }

        public int CourseGroupId { get; set; }
        public CourseGroup? CourseGroup { get; set; }
 
        public List<CourseSettings> CourseSettings { get; set; } = new List<CourseSettings>();
        public List<DosingFrequency> DosingFrequencies { get; set; } = new List<DosingFrequency>();


        //public async Task<TherapyResponse>
        //    Therapy(IResponseLoader<int, Therapy, TherapyResponse> dataLoader, CancellationToken ct)
        //{
        //    var entities = await dataLoader.LoadAsync(x => x.Id == TherapyId);
        //    return entities.FirstOrDefault();
        //}


        //public async Task<CourseGroupResponse>
        //            CourseGroup(IResponseLoader<int, CourseGroup, CourseGroupResponse> dataLoader, CancellationToken ct)
        //{
        //    var entities = await dataLoader.LoadAsync(x => x.Id == CourseGroupId);
        //    return entities?.FirstOrDefault();
        //}
        //public CourseType CourseType { get; set; } = CourseType.None;


        //public async Task<IEnumerable<CourseSettingsResponse>>
        //          CourseSettings(IResponseLoader<int, CourseSettings, CourseSettingsResponse> dataLoader, CancellationToken ct)
        //{
        //    var entities = await dataLoader.LoadAsync(x => x.CourseId == Id);
        //    return entities;
        //}


        //public async Task<IEnumerable<DosingFrequencyResponse>>
        //          DosingFrequencies(IResponseLoader<int, DosingFrequency, DosingFrequencyResponse> dataLoader, CancellationToken ct)
        //{
        //    var entities = await dataLoader.LoadAsync(x => x.CourseId == Id);
        //    return entities;
        //}


    }
}
