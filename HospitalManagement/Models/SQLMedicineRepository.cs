using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public class SQLMedicineRepository: IMedicineRepository
    {
        private readonly AppDbContext context;

        public SQLMedicineRepository(AppDbContext context)
        {
            this.context = context;
        }

        Medicine IMedicineRepository.AddMedicine(Medicine med)
        {
            context.Medicines.Add(med);
            context.SaveChanges();
            return med;
        }

        Medicine IMedicineRepository.DeleteMedicine(int id)
        {
            Medicine med = context.Medicines.FirstOrDefault(m => m.Id == id);
            if(med != null)
            {
                context.Medicines.Remove(med);
                context.SaveChanges();
            }
            return med;
        }

        Medicine IMedicineRepository.GetMedicine(int id)
        {
            Medicine med = context.Medicines.FirstOrDefault(m => m.Id == id);
            return med;
        }

        Medicine IMedicineRepository.UpdateMedicine(Medicine med)
        {
            var medicine = context.Medicines.Attach(med);
            medicine.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return med;
        }
    }
}
