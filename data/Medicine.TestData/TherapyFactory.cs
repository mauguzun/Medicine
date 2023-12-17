using Medicine.Entities.Enums;
using Medicine.Entities.Models.Courses;
using Medicine.Entities.Models.Therapies;
using Medicine.Entities.Models.Translated;

namespace Medicine.TestData
{
    public static class TherapyFactory
    {
        public static Therapy Therapy(int createdById, int assignedUserID, List<Course> courses, TherapyType therapyType = TherapyType.AutoCreated, TherapyStatus therapyStatus = TherapyStatus.None)
        {
            return new Therapy
            {
                AssingedToId = assignedUserID,
                CreatedById = createdById,
                Type = therapyType,
                Status = therapyStatus,
                Translations = new List<TranslatedTherapy> {
                       new TranslatedTherapy
                       {
                           Title = "Therapy ", Description = "Therapy "
                       },
                       new TranslatedTherapy
                       {
                            Title = "Therapy", Description = "sTherapy ",Language = Language.lv
                       }
                    },
                Courses = courses
            };
        }

    }
}
