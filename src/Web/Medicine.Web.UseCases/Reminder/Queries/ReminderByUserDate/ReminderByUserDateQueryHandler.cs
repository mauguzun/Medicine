using AutoMapper;
using MediatR;
using Medicine.DataAccess.Interfaces;
using Medicine.Entities.Enums;
using Medicine.Entities.Models.Auth;
using Medicine.Web.UseCases.Reminder.Dto;
using Medicine.Web.UseCases.Reminder.Queries.ReminderByUserDate;
using Microsoft.EntityFrameworkCore;

namespace Mobile.UseCases.Orders.Queries.GetOrderBy
{
    public class ReminderByUserDateQueryHandler : IRequestHandler<ReminderByUserDateQuery, List<ReminderDto>>
    {
        private readonly IMapper _mapper;
        private readonly IAppDbContextReadonly _dbContext;

        public ReminderByUserDateQueryHandler(IMapper mapper, IAppDbContextReadonly dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<List<ReminderDto>> Handle(ReminderByUserDateQuery request, CancellationToken cancellationToken)
        {
            DateTime firstData = new(1900, 1, 3, 7, 20, 0, 0);
            var lang = Language.en;

            var therapy = _dbContext.Reminders
            .Where(
                    reminder => reminder.TimeInUtc == firstData.ToString("HH:mm") && reminder.UserId == request.UserId
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
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosageLogs.Where(x => x.UserId == request.UserId))
                    .ToList();


            var result = _mapper.Map<List<ReminderDto>>(therapy);

            return result;
        }
    }
}
