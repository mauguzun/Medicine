using DataAccess.Interfaces;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Translated;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Sql
{
    public class AppDbContextReadOnly : DbContext, IAppDbContextReadonly
    {
        public AppDbContextReadOnly(DbContextOptions options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Therapy> Therapies { get; set; }
        public DbSet<ActiveElement> ActiveElements { get; set; }
        public DbSet<CourseSettings> CourseSettings { get; set; }
        public DbSet<DosageRecommendation> DosageRecommendations { get; set; }
        public DbSet<DosingFrequency> DosingFrequencies { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<DrugCategory> DrugCategories { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<ReminderLog> ReminderLogs { get; set; }
        public DbSet<UserSettings> UserSettings { get; set; }

        public DbSet<TranslatedActiveElement> TranslatedActiveElements { get; set; }
        public DbSet<TranslatedCourse> TranslatedCourses { get; set; }
        public DbSet<TranslatedDosageRecommendation> TranslatedDosageRecommendations { get; set; }
        public DbSet<TranslatedDosingFrequency> TranslatedDosingFrequencies { get; set; }
        public DbSet<TranslatedDrugs> TranslatedDrugs { get; set; }
        public DbSet<TranslatedTherapy> TranslatedTherapies { get; set; }
    }
}