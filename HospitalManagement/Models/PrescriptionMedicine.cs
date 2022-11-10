namespace HospitalManagementSystem.Models
{
    public class PrescriptionMedicine
    {
        /*public int id { get; set; }*/
        public Medicine? medicine { get; set; }
        public int medicineId { get; set; }
        public string dose { get; set; }
        public int noOfTablets { get; set; }
        public Prescription? PrescriptionAssociated { get; set; }
        public int PrescriptionId { get; set; }
        public PrescriptionMedicine() { }
        public PrescriptionMedicine(Medicine medicine, string dose, int noOfTablets, Prescription prescription)
        {
            this.medicine = medicine;
            this.medicineId = medicine.Id;
            this.dose = dose;
            this.noOfTablets = noOfTablets;
            PrescriptionAssociated = prescription;
            PrescriptionId = PrescriptionAssociated.Id;
        }
    }
}
