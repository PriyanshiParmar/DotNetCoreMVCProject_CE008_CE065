using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Drawing;

namespace HospitalManagementSystem.Models
{
    public class AppDbContext : DbContext
    {
        /*public AppDbContext()
        {

        }*/
        public AppDbContext(DbContextOptions options): base(options)
        {

        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;database=HospitalDb;Trusted_Connection=true");
            }
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PrescriptionMedicine>().HasOne(pm => pm.medicine);
            modelBuilder.Entity<PrescriptionMedicine>().HasKey(pm => new {pm.PrescriptionId, pm.medicineId});
            modelBuilder.Entity<Prescription>().HasMany(p => p.MedicinesList).WithOne(pm => pm.PrescriptionAssociated).HasForeignKey(pm => pm.PrescriptionId);            
            modelBuilder.Entity<Appointment>().HasOne(a => a.Patient).WithMany(p => p.Appointments).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<Doctor>().HasMany(d => d.Appointments).WithOne(a => a.Doctor).HasForeignKey(a => a.DoctorId);
           
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; } 
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<MedicineComponent> MedicineComponents { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionMedicine> PrescriptionMedicines { get; set; }
        public DbSet<Room> Rooms { get; set; }
        
    }
}
