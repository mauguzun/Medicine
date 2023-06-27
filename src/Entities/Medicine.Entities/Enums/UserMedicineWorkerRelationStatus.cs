namespace Medicine.Entities.Enums
{
    public enum UserMedicineWorkerRelationStatus
    {
        CreatedRequestByUser = 0,
        CreatedRequestByDoctor = 1,
        CanViewThreatmentLogs =10,
        CanAssingThreatment=20,
        DisabledByUser=50,
        DisabledByMediceneWorker=51
    }
}
