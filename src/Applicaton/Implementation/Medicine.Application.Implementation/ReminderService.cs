using Medicine.Application.Interfaces;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Auth;
using Medicine.Infrastructure.Interfcases.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Medicine.Application.Implementation
{
    public class ReminderService : IReminderService
    {

        private readonly IUserService _userService;
        private readonly ILanguageService _languageService;
        private readonly IAppDbContext _context;

        public ReminderService(ILanguageService languageService, IAppDbContext context)
        {
            _languageService = languageService;
            _context = context;
        }

        public IList<Reminder> Get()
        {
            DateTime currentData = new DateTime(1900, 1, 3, 7, 20, 0, 0);

            var lang = _languageService.DefaultLanguage();



            var reminders = _context.Reminders
                .Where(
                    reminder => reminder.TimeInUtc == currentData.ToString("HH:mm")
                     &&
                   (
                    reminder.DosingFrequencyReminders.Any(x => x.DosageLogs == null)
                        ||
                    reminder.DosingFrequencyReminders.Any(x => x.DosageLogs.Any(
                        y => y.DateTime.AddDays(y.DosageRecommendation.DosingFrequency.IntervalInDays) <= currentData
                    )))
                )
                .Include(reminder => reminder.DosingFrequencyReminders)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                .Include(reminder => reminder.DosingFrequencyReminders)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Course)
                    .ThenInclude(t => t.Translations)
                .Include(reminder => reminder.DosingFrequencyReminders)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Course)
                    .ThenInclude(course => course.Therapy)
                    .ThenInclude(t => t.Translations)
                .Include(reminder => reminder.DosingFrequencyReminders)
                    .ThenInclude(dosageRecomendation => dosageRecomendation.DosingFrequency)
                    .ThenInclude(doseFrequency => doseFrequency.Drug)
                    .ThenInclude(t => t.Translations)
            .ToList();


            IList<ReminderLog> logs = new List<ReminderLog>();
            List<User> users = new List<User>();

            reminders.ForEach(reminder =>
            {
                var user = users.Where(x => x.Id == reminder.UserId).FirstOrDefault();
                if (user is null)
                {
                    user = _userService.GetUserById(reminder.UserId.Value);
                    users.Add(user);
                }


                ReminderLog log = new ReminderLog()
                { };

                reminder
                .DosingFrequencyReminders
                .ForEach(x => x.DosingFrequency.Translations.Where(x => x.Language == user.Language).ToList());

                reminder
                .DosingFrequencyReminders
                .ForEach(x => x.DosingFrequency.Course.Translations.Where(x => x.Language == user.Language).ToList());

                reminder
                .DosingFrequencyReminders
                .ForEach(x => x.DosingFrequency.Course.Therapy.Translations.Where(x => x.Language == user.Language).ToList());



            });


            return reminders;

        }
    }

}