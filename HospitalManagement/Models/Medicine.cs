namespace HospitalManagementSystem.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SideEffects { get; set; }
        public string WhoCannotTake { get; set; }
        public string AssociatedDiseases { get; set; }

        //public int Price { get; set; }
        //public int Quantity { get; set; }
        //public DateOnly ManufacturingDate { get; set; }
        //public DateOnly ExpiryDate { get; set; }
        //public string Brand { get; set; }
        //public List<String> Conditions { get; set; }
        //public List<String> Contents { get; set; }

        public Medicine()
        {

        }
        public Medicine(String name, string sideEffect, string cannotTake, string diseases)
        {
            Name = name;
            //AvailableBrands = brands;
            SideEffects = sideEffect;
            WhoCannotTake = cannotTake;
            AssociatedDiseases = diseases;
            //AvailableDoses = dose;
        }
    }
}
