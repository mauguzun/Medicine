using Medicine.Entities.Models.Auth;
using Medicine.Infrastructure.Implementation.DataAccesPsql;
using Medicine.Infrastructure.Interfcases.DataAccess;
using Medicine.TestData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Medicine.WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestDataController : Controller
    {
        private readonly IAppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public TestDataController(IAppDbContext context, UserManager<User> userManager, IServiceScopeFactory serviceScopeFactory)
        {
            _context = context;
            _userManager = userManager;
            _serviceScopeFactory = serviceScopeFactory;
        }

        public async Task<IActionResult> IndexAsync()
        {

            var users = UserFactory.Users(3, false);
            var doctors = UserFactory.Users(3, true);

            var userCreationTasks = users.Select(async user =>
            {
                using (var scope = _serviceScopeFactory.CreateScope())
                {
                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
                    await userManager.CreateAsync(user, "De171717!");
                }
            });


            var doctorCreationTasks = doctors.Select(async doctor =>
            {
                using (var scope = _serviceScopeFactory.CreateScope())
                {
                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
                    await userManager.CreateAsync(doctor, "De171717!");
                }
            });

  
            await Task.WhenAll(doctorCreationTasks);
            await Task.WhenAll(userCreationTasks);


            var activeElements = DrugsFactory.ActiveElements(5);
            var drugsCategories = DrugsFactory.DrugCategories(10);

            _context.ActiveElements.AddRange(activeElements);
            _context.DrugCategories.AddRange(drugsCategories);

            var userId = users.First().Id;

            var drugs = DrugsFactory.Drugs(2, userId, drugsCategories.OrderBy(x => new Random().Next(2, 10)).ToList());
            drugs.AddRange(DrugsFactory.Drugs(2, userId, drugsCategories.OrderBy(x => new Random().Next(2, 10)).ToList()));
            drugs.AddRange(DrugsFactory.Drugs(2, userId, drugsCategories.OrderBy(x => new Random().Next(2, 10)).ToList()));

            _context.Drugs.AddRange(drugs);
            await _context.SaveChagesAsync();

            var remniders = ReminderFactory.Reminders(userId, new List<string>() { "07:00", "17:00" });

            var courses = CourseFactory.Courses(userId, 2);

            _context.Reminders.AddRange(remniders);
            _context.Courses.AddRange(courses);
            await _context.SaveChagesAsync();

            var dosingFreqencies = CourseFactory.DosingFrequencies(courses[0].Id,
                new List<(int drugId, int total, int interval)>() { (drugs[0].Id, 2, 10), (drugs[1].Id, 1, 20) });

            _context.DosingFrequencies.AddRange(dosingFreqencies);
            await _context.SaveChagesAsync();


            var therapy = TherapyFactory.Therapy(doctors[0].Id, userId, courses);
            var dosingFrequencyReminder = ReminderFactory.DosingFrequencyReminder(remniders[0].Id, dosingFreqencies[0].CourseId) ;

            var relation = UserFactory.UserDoctorRelation(userId, doctors[0].Id);

            _context.Therapies.AddRange(therapy);
            _context.DosingFrequencyReminders.AddRange(dosingFrequencyReminder);
            _context.UserDoctorRelations.Add(relation);

            await _context.SaveChagesAsync();
            return Ok();
        }

    }
}