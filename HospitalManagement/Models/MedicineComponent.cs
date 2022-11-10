using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class MedicineComponent
    {
        public Medicine Medicine { get; set; }
        public string Brand { get; set; }
        public int Dose { get; set; }
        [Required]
        [Key]
        public int MfgNo { get; set; }
        public DateTime MfgDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Price { get; set; }

        public MedicineComponent() { }
        public MedicineComponent(Medicine medicine, string brand, int dose, int mfgNo, DateTime mfgDate, DateTime expiryDate, int price)
        {
            Medicine = medicine;
            Brand = brand;
            Dose = dose;
            MfgNo = mfgNo;
            MfgDate = mfgDate;
            ExpiryDate = expiryDate;
            Price = price;
        }
    }
}
