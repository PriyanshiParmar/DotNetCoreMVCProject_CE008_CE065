using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public interface IPrescriptionRepository
    {
        //Add Prescription
        //Add Medicine to prescription
        //Update Prescription
        //Delete Prescription
        //View Prescription
        //Get all prescriptions of a patient

        public Prescription AddPrescription(Prescription prescription);
        public Prescription UpdatePrescription(Prescription prescription);
        //public Prescription AddMedicine(Medicine prescription);
        public Prescription GetPrescription(int id);
        public Prescription DeletePrescription(int id);
        public IList<Prescription> GetPrescriptionOfPatient(Patient patient);
    }
}
