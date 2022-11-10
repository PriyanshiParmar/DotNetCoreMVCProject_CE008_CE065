using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public class SQLDoctorRepository : IDoctorRepository
    {
        private readonly AppDbContext context;
        public SQLDoctorRepository(AppDbContext context)
        {
            this.context = context;
        }

        Doctor IDoctorRepository.AddDoctor(Doctor doctor)
        {
            context.Doctors.Add(doctor);
            context.SaveChanges();
            return doctor;
        }

        Doctor IDoctorRepository.DeleteDoctor(int id)
        {
            Doctor doc = context.Doctors.Find(id);
            if(doc != null)
            {
                context.Doctors.Remove(doc);
                context.SaveChanges();
            }
            return doc;
        }

        Doctor IDoctorRepository.GetDoctor(int id)
        {
            Doctor doctor = context.Doctors.Find(id);
            return doctor;
        }

        Doctor IDoctorRepository.UpdateDoctor(Doctor doctor)
        {
            var doc = context.Doctors.Attach(doctor);
            doc.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return doctor;
        }
    }
}
