using Medicine.Entities.Enums;
using Medicine.Entities.Models.Drugs;
using Medicine.Entities.Models.Translated;

namespace Medicine.TestData
{
    public static class DrugsFactory
    {

        public static List<DrugCategory> DrugCategories(int count)
        {
            var drugCategories = new List<DrugCategory>();

            for (int i = 0; i < count; i++)
            {
                var translations = new List<TranslatedDrugsCategory>();
                foreach (Language lang in Enum.GetValues(typeof(Language)))
                {
                    translations.Add(new TranslatedDrugsCategory()
                    {
                        Language = lang,
                        Title = $"{i} {nameof(TranslatedActiveElement)}  {lang}",
                        Description = $"{i} {nameof(DrugCategory)}  Description  {lang}",
                    });
                }

                drugCategories.Add(new DrugCategory { Translations = translations });

            }

            return drugCategories;
        }

        public static List<Drug> Drugs(int count, int userId, List<DrugCategory> drugsCategories)
        {
            var drugs = new List<Drug>();
            for (int i = 0; i < count; i++)
            {
                var translations = new List<TranslatedDrugs>();
                foreach (Language lang in Enum.GetValues(typeof(Language)))
                {
                    translations.Add(new TranslatedDrugs()
                    {
                        Language = lang,
                        Title = $"{i} {nameof(TranslatedDrugs)}  {lang} ",
                        Description = $"{i} {nameof(TranslatedDrugs)}  Description  {lang}",
                        Recomendation = "Use befor"
                    });
                }

                var drug = new Drug
                {
                    CreatedById = userId,
                    OneUnitSizeInGramm = i + 1,
                    Translations = translations,
                    Title = $"Drug LatinName {i}",
                    DrugCategories = drugsCategories
                };
                drugs.Add(drug);
            }

            return drugs;
        }
        public static List<ActiveElement> ActiveElements(int count)
        {
            var elements = new List<ActiveElement>();
            for (int i = 0; i < count; i++)
            {
                var translates = new List<TranslatedActiveElement>();
                foreach (Language lang in Enum.GetValues(typeof(Language)))
                {
                    translates.Add(new TranslatedActiveElement()
                    {
                        Language = lang,
                        Title = $"{i} {nameof(TranslatedActiveElement)}  Title {lang}",
                        Description = $"{i} {nameof(TranslatedActiveElement)}  Description  {lang}",
                    });
                }

                ActiveElement activeElement = new()
                {
                    Quantity = i + 1,
                    Translations = translates
                };
            }

            return elements;
        }
    }
}
