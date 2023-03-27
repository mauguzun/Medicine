using AutoMapper;
using Medicine.DataAccess.Sql;
using Medicine.Entities.Enums;
using Medicine.Web.UseCases.Dto;
using Microsoft.EntityFrameworkCore;

namespace Medicine.WebApplication.GraphQL.Reminder.Queries
{

    public class Reminder
    {
        [UseProjection]
        [UseSorting()]
        [UseFiltering()]
        public List<ReminderDto> ReadByUserId(
            [Service] AppDbContextReadOnly ctx,
            [Service] IMapper mapper,
            int userId)
        {
            DateTime firstData = new(1900, 1, 3, 7, 20, 0, 0);
            var lang = Language.en;

            var therapy = ctx.Reminders
                .Where(
                    reminder => reminder.TimeInUtc == firstData.ToString("HH:mm") && reminder.UserId == userId
                     &&
                   (
                    reminder.DosageRecommendations.Any(x => x.DosageLogs == null)
                        ||
                    reminder.DosageRecommendations.Any(x => x.DosageLogs.Any(
                        y => y.DateTime.AddDays(y.DosageRecommendation.DosingFrequency.IntervalInDays) <= firstData
                    )))
                )
                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Course)
                    .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Course)
                    .ThenInclude(course => course.Therapy)
                    .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Drug)
                    .ThenInclude(t => t.Translations.Where(t => t.Language == lang))
               .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosageLogs.Where(x => x.UserId == userId))
                    .ToList();

            return mapper.Map<List<ReminderDto>>(therapy);
        }
    }

}