using AutoMapper.Configuration.Annotations;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using Medicine.WebApplication.GraphQL.BaseDataLoader;
using Medicine.WebApplication.GraphQL.Entities.DosageLog.Response;
using Medicine.WebApplication.GraphQL.Entities.DosingFrequency.Response;

namespace Medicine.WebApplication.GraphQL.Entities.DosageRecommendations.Response
{
    public class DosageRecommendationResponse : TranslationsEntityByUserWith<TranslatedDosageRecommendation>
    {
        public double Quantity { get; set; }

        public int ReminderId { get; set; }

        public int DosingFrequencyId { get; set; }

        public async Task<DosingFrequencyResponse>
            DosingFrequency(IResponseLoader<int, Medicine.Entities.Models.DosingFrequency, DosingFrequencyResponse> dataLoader, CancellationToken ct)
        {
            var dosingFrequency = await dataLoader.LoadAsync(x => x.Id == DosingFrequencyId);
            return dosingFrequency?.FirstOrDefault();
        }


        //public async Task<IEnumerable<DosageLogResponse>>
        //    DosageLogs(IResponseLoader<int, Medicine.Entities.Models.DosageLog, DosageLogResponse> dataLoader, CancellationToken ct)
        //{

        //    var dosingFrequency = await dataLoader.LoadAsync(x => x.DosageRecommendationId == Id);
        //    return dosingFrequency;
        //}

    }
}
