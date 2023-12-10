using Medicine.Entities.Models.Base.Interfaces;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.DataLoaders.TranslateDataLoader;
using Medicine.Web.UseCases.Models.GraphqlResponse.Base.Translates;

namespace Medicine.Web.UseCases.Models.GraphqlResponse.Drug
{
    public class DrugCategoryResponse : TranslationEntity<TranslatedDrugsCategory>
    {
        public async Task<IEnumerable<TranslatedResponse>> Translations(
            ITranslateResponseLoader<int, TranslatedDrugsCategory, TranslatedResponse> dataLoader,
            CancellationToken ct)
        {

            var entities = await dataLoader.LoadByCondition(x => x.DrugCategoryId == Id);
            return entities;
        }
    }
}
