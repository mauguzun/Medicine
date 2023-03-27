using Medicine.DataAccess.Interfaces;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Auth;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Medicine.DataAccess.Sql
{
    public class AppDbContextReadOnly : IdentityDbContext<User, Role, int>, IAppDbContextReadonly
    {

        public AppDbContextReadOnly(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TransatedEntityWithDescription>().UseTpcMappingStrategy();
        }


        public DbSet<Course> Courses { get; set; }
        public DbSet<Therapy> Therapies { get; set; }
        public DbSet<ActiveElement> ActiveElements { get; set; }
        public DbSet<CourseSettings> CourseSettings { get; set; }
        public DbSet<DosageRecommendation> DosageRecommendations { get; set; }
        public DbSet<DosingFrequency> DosingFrequencies { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<DrugCategory> DrugCategories { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<DosageLog> DosageLogs { get; set; }
        public DbSet<TranslatedActiveElement> TranslatedActiveElements { get; set; }
        public DbSet<TranslatedCourse> TranslatedCourses { get; set; }
        public DbSet<TranslatedDosageRecommendation> TranslatedDosageRecommendations { get; set; }
        public DbSet<TranslatedDosingFrequency> TranslatedDosingFrequencies { get; set; }
        public DbSet<TranslatedDrugs> TranslatedDrugs { get; set; }
        public DbSet<TranslatedTherapy> TranslatedTherapies { get; set; }
    }
}