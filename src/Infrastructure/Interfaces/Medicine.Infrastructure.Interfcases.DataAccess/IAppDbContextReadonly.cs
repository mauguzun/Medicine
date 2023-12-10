using Medicine.Entities.Models.Auth;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Courses;
using Medicine.Entities.Models.Dosages;
using Medicine.Entities.Models.Drugs;
using Medicine.Entities.Models.Reminders;
using Medicine.Entities.Models.Therapies;
using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models.UserDoctor;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Medicine.Infrastructure.Interfcases.DataAccess
{
    public interface IAppDbContextReadonly
    {
        public DbSet<Course> Courses { get; }
        public DbSet<Therapy> Therapies { get; }
        public DbSet<ActiveElement> ActiveElements { get; }
        public DbSet<CourseSettings> CourseSettings { get; }
        public DbSet<DosingFrequencyReminder> DosingFrequencyReminders { get; }
        public DbSet<DosingFrequency> DosingFrequencies { get; }
        public DbSet<Drug> Drugs { get; }
        public DbSet<DrugCategory> DrugCategories { get; }
        public DbSet<Reminder> Reminders { get; }
        public DbSet<DosageLog> DosageLogs { get; }

        public DbSet<TranslatedActiveElement> TranslatedActiveElements { get; }
        public DbSet<TranslatedCourse> TranslatedCourses { get; }
        public DbSet<TranslatedDosingFrequencyReminder> TranslatedDosageRecommendations { get; }
        public DbSet<TranslatedDosingFrequency> TranslatedDosingFrequencies { get; }
        public DbSet<TranslatedDrugs> TranslatedDrugs { get; }
        public DbSet<TranslatedTherapy> TranslatedTherapies { get; }
        public DbSet<UserDoctorRelation> UserDoctorRelations { get; }
        public DbSet<UserDoctorRelationLog> UserDoctorRelationLogs { get; }
        public DbSet<ReminderLog> ReminderLogs { get; }
        public DbSet<Entities.Models.Auth.Role> Roles { get; }
        public DbSet<User> Users { get; }
        public DbSet<IdentityUserRole<int>> UserRoles { get; }

        DbSet<T> Set<T>() where T : class, IEntity;

    }
}