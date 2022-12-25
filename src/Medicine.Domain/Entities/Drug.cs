using Medicine.Domain.Entities.Base;

namespace Medicine.Domain.Entities
{
    public class Drug : EntityWithDescriptionEntityTransate
    {
        public string? Recomendation { get; set; }
        public double OneItemWeight { get; set; }
        public List<DrugCategory> DrugCategory { get; set; }
        public List<Drug> Analog { get; set; }
        public Dictionary<double, string>? ActiveElements { get; set; }
    }
}
