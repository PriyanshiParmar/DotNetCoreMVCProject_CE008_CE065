using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public class SQLPrescriptionMedicineRepository : IPrescriptionMedicineRepository
    {
        private readonly AppDbContext context;
        public SQLPrescriptionMedicineRepository(AppDbContext context)
        {
            this.context = context;
        }

        PrescriptionMedicine IPrescriptionMedicineRepository.AddPresMed(PrescriptionMedicine presMed)
        {
            context.PrescriptionMedicines.Add(presMed);
            context.SaveChanges();
            return presMed;
        }

        PrescriptionMedicine IPrescriptionMedicineRepository.DeletePresMed(PrescriptionMedicine presMed)
        {
            PrescriptionMedicine presMedicine = context.PrescriptionMedicines.Find(presMed);
            if(presMedicine == null)
            {
                context.PrescriptionMedicines.Remove(presMedicine);
                context.SaveChanges();
            }
            return presMed;
        }

        IList<PrescriptionMedicine> IPrescriptionMedicineRepository.GetAllPresMed(Prescription pres)
        {
            IList<PrescriptionMedicine> myMedicines = context.PrescriptionMedicines.Where(pm => pm.PrescriptionId == pres.Id).ToList();
            return myMedicines;
        }

        PrescriptionMedicine IPrescriptionMedicineRepository.UpdatePresMed(PrescriptionMedicine presMed)
        {
            var med = context.PrescriptionMedicines.Attach(presMed);
            med.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return presMed;
        }
    }
}
