using Medicine.Entities.Models.Base.Interfaces;
using Medicine.Entities.Models.Courses;
using Medicine.Entities.Models.Drugs;
using Medicine.Entities.Models.Translated;

namespace Medicine.Entities.Models.Dosages
{
    /// <summary>
    /// Created inside course , containt time interval ,total , and course 
    /// Description 
    /// </summary>
    public class DosingFrequency : TranslationEntity<TranslatedDosingFrequency>
    {
        public Course Course { get; set; }
        public int CourseId { get; set; }

        public Drug Drug { get; set; }

        public int DrugId { get; set; }

        public double Total { get; set; }
        public int IntervalInDays { get; set; } = 1;

        public List<DosingFrequencyReminder> DosingFrequencyReminders { get; set; }

    }
}