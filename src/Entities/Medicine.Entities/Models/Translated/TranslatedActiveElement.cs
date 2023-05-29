using Medicine.Entities.Models.Translated.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedActiveElement))]
    public class TranslatedActiveElement : TransatedEntityWithDescription
    {
        public ActiveElement ActiveElement { get; set; }
    }

}
