using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.Responses.BaseDataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class ActiveElementResponse : TranslationEntity<TranslatedActiveElement>
    {
        public int DrugId { get; set; }
        public double Quantity { get; set; }
        public async Task<DrugResponse> Drug(IResponseLoader<int, Drug, DrugResponse> dataLoader, CancellationToken ct)
        {

            var drugs = await dataLoader.LoadAsync(x => x.Id == DrugId);
            return drugs.FirstOrDefault() ;
        }
    }
  
}
