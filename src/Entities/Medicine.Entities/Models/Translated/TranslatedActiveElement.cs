using Medicine.Entities.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.Translated
{
    [Table(nameof(TranslatedActiveElement))]
    public class TranslatedActiveElement : TransatedEntityWithDescription
    {
        [ForeignKey("ActiveElementId")]
        public ActiveElement ActiveElement { get; set; }
        public int ActiveElementId { get; set; }    
    }

}
