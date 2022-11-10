using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public interface IPatientRepository
    {
        //Add Patient
        //Update patient details
        //Delete patient
        //Get patient details

        public Patient GetPatient(int id);
        public Patient AddPatient(Patient patient);
        public Patient UpdatePatient(Patient patient);
        public Patient DeletePatient(int id);
    }
}
