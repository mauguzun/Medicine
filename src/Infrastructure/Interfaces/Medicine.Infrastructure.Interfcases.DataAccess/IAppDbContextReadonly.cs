using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
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
        public DbSet<UserMedicineWorker> UserMedicineWorkers { get; }
        public DbSet<UserMedicineWorkerLog> UserMedicineWorkerLogs { get; }
        public DbSet<ReminderLog> ReminderLogs { get; }

        DbSet<T> Set<T>() where T : class, IEntity;

    }
}