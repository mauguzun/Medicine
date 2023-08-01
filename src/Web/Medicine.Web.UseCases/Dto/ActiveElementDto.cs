using Medicine.Entities.Models;
using Medicine.Entities.Models.Base.Interfaces;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.DataLoaders.DataLoader;

namespace Medicine.Web.UseCases.Responses
{
    public class ActiveElementResponse : TranslationEntity<TranslatedActiveElement>
    {
        public int DrugId { get; set; }
        public double Quantity { get; set; }
        public async Task<DrugDto> Drug(IResponseLoader<int, Drug, DrugDto> dataLoader, CancellationToken ct)
        {

            var drugs = await dataLoader.LoadByCondition(x => x.Id == DrugId);
            return drugs.FirstOrDefault() ;
        }
    }
  
}