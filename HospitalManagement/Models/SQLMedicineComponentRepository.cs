using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public class SQLMedicineComponentRepository: IMedicineComponentRepository
    {
        private readonly AppDbContext context;
        public SQLMedicineComponentRepository(AppDbContext context)
        {
            this.context = context;
        }

        MedicineComponent IMedicineComponentRepository.AddMedCompo(MedicineComponent medComp)
        {
            context.MedicineComponents.Add(medComp);
            context.SaveChanges();
            return medComp;
        }

        MedicineComponent IMedicineComponentRepository.DeleteMedCompo(int mfgNo)
        {
            MedicineComponent med = context.MedicineComponents.FirstOrDefault(m=>m.MfgNo == mfgNo);
            if(med != null)
            {
                context.MedicineComponents.Remove(med);
                context.SaveChanges();
            }
            return med;
        }

        MedicineComponent IMedicineComponentRepository.UpdateMedCompo(MedicineComponent medCompoChanges)
        {
            var med = context.MedicineComponents.Attach(medCompoChanges);
            med.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return medCompoChanges;
        }
    }
}
