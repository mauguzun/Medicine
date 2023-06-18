using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Web.UseCases.DataLoaders.BaseDataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class SimilarDrugsResponse : Entity
    {
        public async Task<IEnumerable<DrugResponse>> SimilarDrugsList(
           IResponseLoader<int, Drug, DrugResponse> dataLoader,
           CancellationToken ct)
        {

            var entities = await dataLoader.LoadByCondition(x => x.SimilarDrugsId == Id);
            return entities;
        }
    }
}
