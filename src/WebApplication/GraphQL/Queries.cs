using Medicine.DataAccess.Sql;
using Medicine.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Medicine.WebApplication.GraphQl
{

    public class Queries
    {
        [UseProjection]
        public IQueryable<Reminder> Read([Service] AppDbContextReadOnly ctx)
        {
            DateTime firstData = new DateTime(1900, 1, 3, 7, 20, 0, 0);

            return ctx.Reminders
                .Where(
                     reminder => reminder.TimeInUtc == firstData.ToString("HH:mm") && reminder.CreatedBy == userId
                     &&
                   (
                    reminder.DosageRecommendations.Any(x => x.DosageLogs == null)
                        ||
                    reminder.DosageRecommendations.Any(x => x.DosageLogs.Any(
                        y => y.DateTime.AddDays(y.DosageRecommendation.DosingFrequency.IntervalInDays) <= firstData
                    )))
                )
                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Course)
                    .ThenInclude(course => course.Therapy)
                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Drug)
                    .ThenInclude(dose => dose.TranslatedDrugs)
               .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosageLogs.Where(x => x.CreatedBy == 1));


        }

        [UseProjection]
        [UseSorting()]
        [UseFiltering()]
        public IQueryable<Reminder> ReadByUserId([Service] AppDbContextReadOnly ctx, int userId)
        {
            DateTime firstData = new DateTime(1900, 1, 3, 7, 20, 0, 0);

            return ctx.Reminders
                .Where(
                    reminder => reminder.TimeInUtc == firstData.ToString("HH:mm") && reminder.CreatedBy == userId
                     &&
                   (
                    reminder.DosageRecommendations.Any(x => x.DosageLogs == null)
                        ||
                    reminder.DosageRecommendations.Any(x => x.DosageLogs.Any(
                        y => y.DateTime.AddDays(y.DosageRecommendation.DosingFrequency.IntervalInDays) <= firstData
                    )))
                )
                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Course)
                    .ThenInclude(course => course.Therapy)
                .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Drug)
                    .ThenInclude(dose => dose.TranslatedDrugs)
               .Include(reminder => reminder.DosageRecommendations)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosageLogs.Where(x => x.CreatedBy == userId));


        }
    }

}