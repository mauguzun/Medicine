using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.Responses.BaseDataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class DrugCategoryResponse : TranslationEntity<TranslatedDrugsCategory>
    {
        public int DrugId { get; set; }

        public async Task<IEnumerable<DrugResponse>> Drugs(IResponseLoader<int, Drug, DrugResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadAsync(x => x.Id == DrugId);
            return entities;
        }

    }
}
