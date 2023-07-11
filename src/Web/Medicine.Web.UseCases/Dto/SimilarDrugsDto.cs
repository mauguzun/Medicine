using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Web.UseCases.DataLoaders.DataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class SimilarDrugsDto : Entity
    {
        public async Task<IEnumerable<DrugDto>> SimilarDrugsList(
           IResponseLoader<int, Drug, DrugDto> dataLoader,
           CancellationToken ct)
        {

            var entities = await dataLoader.LoadByCondition(x => x.SimilarDrugsId == Id);
            return entities;
        }
    }
}
