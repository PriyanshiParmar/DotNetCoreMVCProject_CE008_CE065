using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public interface IDoctorRepository
    {
        //Add doctor
        //Update Doctor
        //Delete Doctor
        //Get Doctor Details

        public Doctor GetDoctor(int id);
        public Doctor UpdateDoctor(Doctor doctor);
        public Doctor DeleteDoctor(int id);
        public Doctor AddDoctor(Doctor doctor);
    }
}
