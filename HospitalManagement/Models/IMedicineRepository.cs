using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public interface IMedicineRepository
    {
        //Add medicine
        //Update medicine
        //Delete medicine
        //Get medicine

        public Medicine GetMedicine(int id);
        public Medicine AddMedicine(Medicine med);
        public Medicine UpdateMedicine(Medicine med);
        public Medicine DeleteMedicine(int id);
    }
}
