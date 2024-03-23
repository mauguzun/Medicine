using Medicine.Entities.Enums;
using Medicine.Entities.Models.Auth;
using Medicine.Entities.Models.UserDoctor;
using System.Numerics;

namespace Medicine.TestData
{
    public static class UserFactory
    {
        public static List<User> Users(int count, bool isDoctor)
        {
            var users = new List<User>();
            for (int i = 0; i < count; i++)
            {
                users.Add(
                    new User()
                    {
                        Birthday = DateOnly.FromDateTime(DateTime.UtcNow),
                        Email = isDoctor ? $"mauguzun+doc{count}@gmail.com" : $"mauguzun+{count}@gmail.com",
                        EmailConfirmed = true,
                        Role = isDoctor ? Entities.Enums.SystemRole.MedicineWorker : Entities.Enums.SystemRole.User,
                        UserName = isDoctor ? $"mauguzun+doc{count}@gmail.com" : $"mauguzun+{count}@gmail.com",
                    });
            }
            return users;
        }

        public static UserDoctorRelation UserDoctorRelation(int userId, int doctorId,
            bool createByUser = true, UserDoctorRelationType userDoctorRelationType = UserDoctorRelationType.CanAssingThreatment, DateTime? acceptedAt = null)
        {
            return new UserDoctorRelation()
            {
                CreatedById = userId,
                DoctorId = doctorId,
                CreatedByUser = createByUser,
                UserDoctorRelationType = userDoctorRelationType,
                AcceptedAt = acceptedAt
            };
        }
    }
}
