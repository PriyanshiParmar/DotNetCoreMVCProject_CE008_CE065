using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Prescription
    {
        [Key]
        public int Id { get; set; }
        
        public IEnumerable<PrescriptionMedicine> MedicinesList { get; set; }
        public Patient? Patient { get; set; }
        [ForeignKey("PatientId")]
        public int PatientId { get; set; }
        public DateTime Date { get; set; }
        public Prescription() 
        { 
            MedicinesList = new List<PrescriptionMedicine>();
        }
        public Prescription(IEnumerable<PrescriptionMedicine> medicinesList, Patient patient, DateTime date)
        {
            MedicinesList = medicinesList;
            Patient = patient;
            Date = date;
        }
        


    }
}
