using Medicine.Entities.Enums;

namespace Medicine.Application.Interfaces
{
    public interface ILanguageService
    {
        Language Language();
        Language DefaultLanguage();
    }
}