using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public interface IPrescriptionMedicineRepository
    {
        //Add Pres Med
        //Update Pres Med
        //Delete Pres Med
        //Get all pres med by pres id

        public PrescriptionMedicine AddPresMed(PrescriptionMedicine presMed);
        public PrescriptionMedicine UpdatePresMed(PrescriptionMedicine presMed);
        public PrescriptionMedicine DeletePresMed(PrescriptionMedicine presMed);
        public IList<PrescriptionMedicine> GetAllPresMed(Prescription pres);

    }
}
