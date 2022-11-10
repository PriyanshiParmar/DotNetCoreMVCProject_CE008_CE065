using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public class SQLPrescriptionRepository : IPrescriptionRepository
    {
        private readonly AppDbContext context;
        public SQLPrescriptionRepository(AppDbContext context)
        {
            this.context = context;
        }
        Prescription IPrescriptionRepository.AddPrescription(Prescription prescription)
        {
            context.Prescriptions.Add(prescription);
            context.SaveChanges();
            return prescription;
        }

        Prescription IPrescriptionRepository.DeletePrescription(int id)
        {
            Prescription pres = context.Prescriptions.Find(id);
            if(pres != null)
            {
                context.Prescriptions.Remove(pres);
                context.SaveChanges();
            }
            return pres;
        }

        Prescription IPrescriptionRepository.GetPrescription(int id)
        {
            Prescription pres = context.Prescriptions.Find(id);
            return pres;
        }

        IList<Prescription> IPrescriptionRepository.GetPrescriptionOfPatient(Patient patient)
        {
            IList <Prescription> prescriptions = context.Prescriptions.Where(p => p.Patient == patient).ToList();
            return prescriptions;
        }

        Prescription IPrescriptionRepository.UpdatePrescription(Prescription prescriptionChanges)
        {
            var pres = context.Prescriptions.Attach(prescriptionChanges);
            pres.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return prescriptionChanges;
        }
    }
}
