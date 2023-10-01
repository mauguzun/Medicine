using Medicine.Entities.Enums;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Auth;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using Medicine.Entities.Models.Translated.Base;
using Medicine.Infrastructure.Interfcases.DataAccess;
using Microsoft.AspNetCore.Identity;
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

            //modelBuilder.Entity<DrugDrugCategory>().HasKey(sc => new { sc.DrugId, sc.DrugCategoryId });

            modelBuilder.Entity<TransatedEntityWithDescription>().UseTpcMappingStrategy();

            modelBuilder.Entity<TranslatedActiveElement>().HasIndex(p => new { p.Language, p.ActiveElementId }).IsUnique();
            modelBuilder.Entity<TranslatedCourse>().HasIndex(p => new { p.Language, p.CourseId }).IsUnique();
            modelBuilder.Entity<TranslatedCourseGroup>().HasIndex(p => new { p.Language, p.CourseGroupId }).IsUnique();
            modelBuilder.Entity<TranslatedDosingFrequencyReminder>().HasIndex(p => new { p.Language, p.DosageRecommendationId }).IsUnique();
            modelBuilder.Entity<TranslatedDrugs>().HasIndex(p => new { p.Language, p.DrugId }).IsUnique();
            modelBuilder.Entity<TranslatedDrugsCategory>().HasIndex(p => new { p.Language, p.DrugCategoryId }).IsUnique();
            modelBuilder.Entity<TranslatedTherapy>().HasIndex(p => new { p.Language, p.TherapyId }).IsUnique();
            modelBuilder.Entity<TranslatedActiveElement>().HasIndex(p => new { p.Language, p.ActiveElementId }).IsUnique();


            //modelBuilder.Entity<TranslatedCourseGroup>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<ActiveElement>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<CourseSettings>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<CourseSettings>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<DosingFrequencyReminder>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<DrugCategory>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<Therapy>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<DosingFrequency>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<Entities.Models.DosageLog>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<Reminder>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<SimilarDrugs>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<Drug>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<Course>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<ReminderLog>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<UserMedicineWorkerLog>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<UserMedicineWorker>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<TranslatedTherapy>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<TranslatedDrugs>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<TranslatedDrugsCategory>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<TranslatedDosingFrequency>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<TranslatedDosingFrequencyReminder>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<TranslatedCourse>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<TranslatedActiveElement>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<User>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<Role>().Property(p => p.Id).UseIdentityAlwaysColumn();

            //modelBuilder.Entity<IdentityRoleClaim<int>>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<IdentityRole<int>>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<IdentityRoleClaim<int>>().Property(p => p.Id).UseIdentityAlwaysColumn();
            //modelBuilder.Entity<IdentityUserClaim<int>>().Property(p => p.Id).UseIdentityAlwaysColumn();



            // seeding
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = SystemRole.User.ToString(), NormalizedName = SystemRole.User.ToString().ToUpper() },
                new Role { Id = 2, Name = SystemRole.MedicineWorker.ToString(), NormalizedName = SystemRole.MedicineWorker.ToString().ToUpper() }
            );
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Therapy> Therapies { get; set; }
        public DbSet<ActiveElement> ActiveElements { get; set; }
        public DbSet<CourseSettings> CourseSettings { get; set; }
        public DbSet<DosingFrequencyReminder> DosingFrequencyReminders { get; set; }
        public DbSet<DosingFrequency> DosingFrequencies { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<SimilarDrugs> SimilarDrugs { get; set; }
        public DbSet<DrugCategory> DrugCategories { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Entities.Models.DosageLog> DosageLogs { get; set; }
        public DbSet<TranslatedActiveElement> TranslatedActiveElements { get; set; }
        public DbSet<TranslatedCourse> TranslatedCourses { get; set; }
        public DbSet<TranslatedDosingFrequencyReminder> TranslatedDosageRecommendations { get; set; }
        public DbSet<TranslatedDosingFrequency> TranslatedDosingFrequencies { get; set; }
        public DbSet<TranslatedDrugs> TranslatedDrugs { get; set; }
        public DbSet<TranslatedTherapy> TranslatedTherapies { get; set; }
        public DbSet<UserMedicineWorker> UserMedicineWorkers { get; set; }
        public DbSet<UserMedicineWorkerLog> UserMedicineWorkerLogs { get; set; }
        public DbSet<ReminderLog> ReminderLogs { get; set; }

        public new DbSet<T> Set<T>() where T : class, IEntity => base.Set<T>();

    }
}