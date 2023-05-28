using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.Responses.BaseDataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class DrugResponse : TranslationsEntityByUserWith<TranslatedDrugs>
    {
        public string? Recomendation { get; set; }
        public string? Title { get; set; }
        public double OneUnitSizeInGramm { get; set; }

        public async Task<IEnumerable<DrugCategoryResponse>> DrugCategories(IResponseLoader<int, DrugCategory, DrugCategoryResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadAsync(x => x.DrugId == Id);
            return entities;
        }
        //public async Task<IEnumerable<DrugResponse>> SimilarPreparate(IResponseLoader<int, Drug, DrugResponse> dataLoader, CancellationToken ct)
        //{
        //    var entities = await dataLoader.LoadAsync(x => x.Id == Id);
        //    return entities;
        //}


        public async Task<IEnumerable<ActiveElementResponse>> ActiveElements(IResponseLoader<int, ActiveElement, ActiveElementResponse> dataLoader, CancellationToken ct)
        {
            var entities = await dataLoader.LoadAsync(x => x.DrugId == Id);
            return entities;
        }

    }
}
