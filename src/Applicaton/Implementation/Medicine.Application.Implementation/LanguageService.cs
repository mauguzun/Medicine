using Medicine.Application.Interfaces;
using Medicine.Entities.Enums;

namespace Medicine.Application.Implementation
{
    public class LanguageService : ILanguageService
    {
        public Language DefaultLanguage() => Entities.Enums.Language.en;

        public Language Language() => Entities.Enums.Language.en;
    }
}