using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public interface IMedicineComponentRepository
    {
        //Add med comp
        //Update med comp
        //Del med comp

        public MedicineComponent AddMedCompo(MedicineComponent medComp);
        public MedicineComponent DeleteMedCompo(int mfgNo);
        public MedicineComponent UpdateMedCompo(MedicineComponent medCompoChanges);
    }
}
