using Medicine.Domain.Entities.Base;
using Medicine.Domain.EntityTranslate.Base;

namespace Medicine.Domain.EntityTranslate
{
	public class TranslateDrug : TransateEntityWithDescription
	{
		public Drug Drug { get; set; }

		public string Recomendation { get; set; }
	}
}
