using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public class SQLNurseRepository: INurseRepository
    {
        private readonly AppDbContext context;
        public SQLNurseRepository(AppDbContext context)
        {
            this.context = context;
        }

        Nurse INurseRepository.AddNurse(Nurse nurse)
        {
            context.Nurses.Add(nurse);
            context.SaveChanges();
            return nurse;
        }

        Nurse INurseRepository.DeleteNurse(int id)
        {
            Nurse nurse = context.Nurses.Find(id);
            if(nurse != null)
            {
                context.Nurses.Remove(nurse);
                context.SaveChanges();
            }
            return nurse;
        }

        Nurse INurseRepository.GetNurse(int id)
        {
            Nurse nurse = context.Nurses.Find(id);
            return nurse;
        }

        Nurse INurseRepository.UpdateNurse(Nurse nurseChanges)
        {
            var nurse = context.Nurses.Attach(nurseChanges);
            nurse.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return nurseChanges;
        }
    }
}
