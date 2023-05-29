using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    public class ActiveElement : TranslationEntity<TranslatedActiveElement>
    {
        public int DrugId { get; set; }
        public Drug Drug { get; set; }
        public double Quantity { get; set; }
    }
}
