using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models
{
    public class ActiveElement : Entity
    {
        public double Quantity { get; set; }
        public TranslatedActiveElement TranslatedActiveElement { get; set; }
    }
}
