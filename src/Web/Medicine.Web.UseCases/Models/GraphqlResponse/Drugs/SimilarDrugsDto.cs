using Medicine.Entities.Models.Base;
using Medicine.Web.UseCases.DataLoaders.DataLoader;

namespace Medicine.Web.UseCases.Models.GraphqlResponse.Drug
{
    public class SimilarDrugsDto : Entity
    {
        public async Task<IEnumerable<DrugReponse>> SimilarDrugsList(
           IResponseLoader<int, Entities.Models.Drugs.Drug, DrugReponse> dataLoader,
           CancellationToken ct)
        {

            var entities = await dataLoader.LoadByCondition(x => x.SimilarDrugsId == Id);
            return entities;
        }
    }
}
