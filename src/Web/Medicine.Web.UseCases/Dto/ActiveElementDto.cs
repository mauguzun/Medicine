namespace Medicine.Web.UseCases.Dto
{
    public class ActiveElementDto : TransatedEntityWithDescriptionDto
    {
        public int DrugId { get; set; }
        public DrugDto Drug { get; set; }
        public double Quantity { get; set; }
    }
}
