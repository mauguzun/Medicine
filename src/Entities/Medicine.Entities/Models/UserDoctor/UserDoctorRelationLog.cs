using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models.UserDoctor
{
    public class UserDoctorRelationLog : Entity
    {
        public int UserDoctorRelationId { get; set; }
        public UserDoctorRelation UserDoctorRelation { get; set; }
        public UserDoctorRelationType UserDoctorRelationType { get; set; }
    }
}
