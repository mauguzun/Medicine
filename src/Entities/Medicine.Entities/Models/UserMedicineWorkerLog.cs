using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    public class UserMedicineWorkerLog : Entity
    {
        public int UserMedicineWorkerId;
        public UserMedicineWorker? UserMedicineWorker;
        public UserMedicineWorkerRelationStatus UserMedicineWorkerRelationStatus { get; set; }
    }
}
