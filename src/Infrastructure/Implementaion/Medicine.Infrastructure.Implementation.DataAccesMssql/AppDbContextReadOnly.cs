﻿using Medicine.Entities.Enums;
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

            //modelBuilder.Entity<DrugDrugCategory>().HasKey(sc => new { sc.DrugId, sc.DrugCategoryId });

            modelBuilder.Entity<TransatedEntityWithDescription>().UseTpcMappingStrategy();

            modelBuilder.Entity<TranslatedActiveElement>().HasIndex(p => new { p.Language, p.ActiveElementId }).IsUnique();
            modelBuilder.Entity<TranslatedCourse>().HasIndex(p => new { p.Language, p.CourseId }).IsUnique();
            modelBuilder.Entity<TranslatedCourseGroup>().HasIndex(p => new { p.Language, p.CourseGroupId }).IsUnique();
            modelBuilder.Entity<TranslatedDosingFrequencyReminder>().HasIndex(p => new { p.Language, p.DosageRecommendationId }).IsUnique();
            modelBuilder.Entity<TranslatedActiveElement>().HasIndex(p => new { p.Language, p.ActiveElementId }).IsUnique();
            modelBuilder.Entity<TranslatedDrugs>().HasIndex(p => new { p.Language, p.DrugId }).IsUnique();
            modelBuilder.Entity<TranslatedDrugsCategory>().HasIndex(p => new { p.Language, p.DrugCategoryId }).IsUnique();
            modelBuilder.Entity<TranslatedTherapy>().HasIndex(p => new { p.Language, p.TherapyId }).IsUnique();

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