using Medicine.Entities.Enums;
using Medicine.Entities.Models.Auth;
using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    public class UserMedicineWorker : Entity
    {
        public User? User { get; set; }
        public User? MedicineWorker { get; set; }
        public UserMedicineWorkerRelationStatus UserMedicineWorkerRelationStatus { get; set; } = UserMedicineWorkerRelationStatus.CreatedRequestByUser;
        public DateTimeOffset? CreatedRequest { get; set; }
        public DateTimeOffset? AcceptedRequest { get; set; }

    }
}
