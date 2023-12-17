using Medicine.Entities.Enums;
using Medicine.Entities.Models.Auth;
using Medicine.Entities.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Entities.Models.UserDoctor
{
    public class UserDoctorRelation : EntityUser
    {
        public User? Doctor { get; set; }

        [ForeignKey(nameof(Doctor))]
        public int? DoctorId { get; set; }

        public UserDoctorRelationType UserDoctorRelationType { get; set; } = UserDoctorRelationType.None;
        public bool CreatedByUser { get; set; }
        public DateTime? AcceptedAt { get; set; }

    }
}
