using Medicine.Entities.Models.Base.Interfaces;
using Medicine.Entities.Models.Drugs;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.DataLoaders.DataLoader;
using Medicine.Web.UseCases.DataLoaders.TranslateDataLoader;
using Medicine.Web.UseCases.Models.GraphqlResponse.Base.Translates;

namespace Medicine.Web.UseCases.Models.GraphqlResponse.Drug
{
    public class DrugReponse : TranslationEntity<TranslatedDrugs>
    {
        public string? Recomendation { get; set; }
        public string? Title { get; set; }
        public double OneUnitSizeInGramm { get; set; }
        public int SimilarDrugsId { get; set; }

        public async Task<IEnumerable<TranslatedDrugsResponce>> Translations(ITranslateResponseLoader<int, TranslatedDrugs, TranslatedDrugsResponce> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.DrugId == Id);
            return entities;
        }

        public async Task<IEnumerable<DrugCategoryResponse>>
            DrugCategories(IResponseLoader<int, DrugCategory, DrugCategoryResponse> dataLoader,
            CancellationToken ct)
        {
            var entities = await dataLoader.LoadCategoriesByDrugId(Id);
            return entities;
        }

        public async Task<IEnumerable<SimilarDrugsDto>>
           SimilarDrugsList(IResponseLoader<int, SimilarDrugs, SimilarDrugsDto> dataLoader,
           CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.Id == SimilarDrugsId);
            return entities;
        }


        public async Task<IEnumerable<ActiveElementResponse>> ActiveElements(
            IResponseLoader<int, ActiveElement, ActiveElementResponse> dataLoader,
            CancellationToken ct)
        {
            var entities = await dataLoader.LoadByCondition(x => x.DrugId == Id);
            return entities;
        }


    }
}
