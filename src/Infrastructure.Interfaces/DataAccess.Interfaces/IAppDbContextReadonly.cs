using Medicine.Entities.Models;
using Medicine.Entities.Models.Translated;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Interfaces
{
    public interface IAppDbContextReadonly
    {
        public DbSet<Course> Courses {get;}
        public DbSet<Therapy> Therapies {get;}
        public DbSet<ActiveElement> ActiveElements {get;}
        public DbSet<CourseSettings> CourseSettings {get;}
        public DbSet<DosageRecommendation> DosageRecommendations {get;}
        public DbSet<DosingFrequency> DosingFrequencies {get;}
        public DbSet<Drug> Drugs {get;}
        public DbSet<DrugCategory> DrugCategories {get;}
        public DbSet<Reminder> Reminders {get;}
        public DbSet<ReminderLog> ReminderLogs {get;}
        public DbSet<UserSettings> UserSettings {get;}

        public DbSet<TranslatedActiveElement> TranslatedActiveElements {get;}
        public DbSet<TranslatedCourse> TranslatedCourses {get;}
        public DbSet<TranslatedDosageRecommendation> TranslatedDosageRecommendations {get;}
        public DbSet<TranslatedDosingFrequency> TranslatedDosingFrequencies {get;}
        public DbSet<TranslatedDrugs> TranslatedDrugs {get;}
        public DbSet<TranslatedTherapy> TranslatedTherapies {get;}
    }
}