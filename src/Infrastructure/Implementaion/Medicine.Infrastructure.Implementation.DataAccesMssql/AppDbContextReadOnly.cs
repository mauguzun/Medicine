using Medicine.Entities.Enums;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Auth;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models.Translated.Base;
using Medicine.Infrastructure.Interfcases.DataAccess;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Medicine.Infrastructure.Implementation.DataAccesMssql
{
    public class AppDbContextReadOnly : IdentityDbContext<User, Role, int>, IAppDbContextReadonly
    {
       
        public AppDbContextReadOnly(DbContextOptions options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TransatedEntityWithDescription>().UseTpcMappingStrategy();

            // seeding
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = SystemRole.User.ToString() },
                new Role { Id = 2, Name = SystemRole.Doctor.ToString() }
            );
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Therapy> Therapies { get; set; }
        public DbSet<ActiveElement> ActiveElements { get; set; }
        public DbSet<CourseSettings> CourseSettings { get; set; }
        public DbSet<DosingFrequencyReminder> DosingFrequencyReminders { get; set; }
        public DbSet<DosingFrequency> DosingFrequencies { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<DrugCategory> DrugCategories { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<DosageLog> DosageLogs { get; set; }
        public DbSet<TranslatedActiveElement> TranslatedActiveElements { get; set; }
        public DbSet<TranslatedCourse> TranslatedCourses { get; set; }
        public DbSet<TranslatedDosingFrequencyReminder> TranslatedDosageRecommendations { get; set; }
        public DbSet<TranslatedDosingFrequency> TranslatedDosingFrequencies { get; set; }
        public DbSet<TranslatedDrugs> TranslatedDrugs { get; set; }
        public DbSet<TranslatedTherapy> TranslatedTherapies { get; set; }


        public new DbSet<T> Set<T>() where T : class, IEntity
        {
            return base.Set<T>();
        }


    }
}