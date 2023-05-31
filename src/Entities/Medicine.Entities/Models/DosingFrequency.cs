using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Translated;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models
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