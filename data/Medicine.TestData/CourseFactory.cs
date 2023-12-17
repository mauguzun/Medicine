using Medicine.Entities.Enums;
using Medicine.Entities.Models.Courses;
using Medicine.Entities.Models.Dosages;
using Medicine.Entities.Models.Translated;

namespace Medicine.TestData
{
    public static class CourseFactory
    {
        public static List<Course> Courses(int userId,
            int count, CourseType courseType = CourseType.None , int? courseGroup = null,   List<CourseSettings> courseSettings = null )
        {
            var courses = new List<Course>();
            for (int i = 0; i < count; i++)
            {
                var course = new Course
                {
                    CreatedById = userId,
                    Translations = new List<TranslatedCourse>  {
                               new TranslatedCourse { Title = "AutoCrated2", Description = "AutoCreated2",Language = Language.lv },
                               new TranslatedCourse { Title = "AutoCrated", Description = "AutoCreated"}
                           },
                    CourseType= courseType,
                    CourseGroupID = courseGroup,
                    CourseSettings = courseSettings,
                };
                courses.Add(course);
            }

            return courses;
        }

        public static List<DosingFrequency> DosingFrequencies(int courseId, List<(int drugId, int interval, int total)> Params)
        {
            var dosingFrequncies = new List<DosingFrequency>();
            Params.ForEach(param =>
            {
                var dosing = new DosingFrequency
                {
                    CourseId = courseId,
                    Total = param.total,
                    DrugId = param.drugId,
                    IntervalInDays = param.interval,
                    Translations = new List<TranslatedDosingFrequency>
                                    {
                                         new TranslatedDosingFrequency
                                         {
                                             Title = "TranslatedDosingFrequency",
                                             Description =  "TranslatedDosingFrequency Description"
                                         },
                                          new TranslatedDosingFrequency
                                         {
                                             Title = "TranslatedDosingFrequency",
                                             Description =  "TranslatedDosingFrequency Description",
                                             Language = Language.lv
                                         }
                                    },
                };
                dosingFrequncies.Add(dosing);
            });
            return dosingFrequncies;
        }
    }
}
