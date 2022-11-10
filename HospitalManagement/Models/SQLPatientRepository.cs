using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public class SQLPatientRepository: IPatientRepository
    {
        private readonly AppDbContext context;
        public SQLPatientRepository(AppDbContext context)
        {
            this.context = context;
        }

        Patient IPatientRepository.AddPatient(Patient patient)
        {
            context.Patients.Add(patient);
            context.SaveChanges();
            return patient;
        }

        Patient IPatientRepository.DeletePatient(int id)
        {
            Patient patient = context.Patients.FirstOrDefault(p=>p.Id == id);
            if(patient != null)
            {
                context.Patients.Remove(patient);
                context.SaveChanges();
            }
            return patient;
        }

        Patient IPatientRepository.GetPatient(int id)
        {
            Patient patient = context.Patients.FirstOrDefault(patient => patient.Id == id);
            return patient;
        }

        Patient IPatientRepository.UpdatePatient(Patient patient)
        {
            var myPatient = context.Patients.Attach(patient);
            myPatient.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return patient;
        }
    }
}
