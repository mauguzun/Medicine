using Medicine.Entities.Models.Base.Interfaces;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.DataLoaders.DataLoader;

namespace Medicine.Web.UseCases.Models.GraphqlResponse.Drug
{
    public class ActiveElementResponse : TranslationEntity<TranslatedActiveElement>
    {
        public int DrugId { get; set; }
        public double Quantity { get; set; }
        public async Task<DrugReponse> Drug(IResponseLoader<int, Entities.Models.Drugs.Drug, DrugReponse> dataLoader, CancellationToken ct)
        {

            var drugs = await dataLoader.LoadByCondition(x => x.Id == DrugId);
            return drugs.FirstOrDefault();
        }
    }

}
