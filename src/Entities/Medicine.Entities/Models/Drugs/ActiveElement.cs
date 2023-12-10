using Medicine.Entities.Models.Base.Interfaces;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models.Drugs
{
    public class ActiveElement : TranslationEntity<TranslatedActiveElement>
    {
        public int DrugId { get; set; }
        public Drug Drug { get; set; }
        public double Quantity { get; set; }
    }
}
