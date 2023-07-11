using Medicine.Entities.Models;
using Medicine.Entities.Models.Base.Interfaces;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.DataLoaders.DataLoader;
using Medicine.Web.UseCases.DataLoaders.TranslateDataLoader;
using Medicine.Web.UseCases.Responses.Translates;

namespace Medicine.Web.UseCases.Responses
{
    public class DrugDto : TranslationEntity<TranslatedDrugs>
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

        public async Task<IEnumerable<DrugCategoryDto>>
            DrugCategories(IResponseLoader<int, DrugCategory, DrugCategoryDto> dataLoader, 
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
