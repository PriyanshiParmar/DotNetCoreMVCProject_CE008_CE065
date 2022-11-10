using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public interface INurseRepository
    {
        //Add, update, delete, retrieve

        public Nurse GetNurse(int id);
        public Nurse AddNurse(Nurse nurse);
        public Nurse UpdateNurse(Nurse nurseChanges);
        public Nurse DeleteNurse(int id);
    }
}
