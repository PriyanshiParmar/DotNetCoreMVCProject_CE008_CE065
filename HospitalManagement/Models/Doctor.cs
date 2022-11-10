namespace HospitalManagementSystem.Models
{
    public class Doctor: Staff
    {
        /*public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }*/
        public string Speciality { get; set; }
        /*public long MobileNo { get; set; }*/
        public ICollection<Patient>? Patients { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
        /*public int Salary { get; set; }*/

        public Doctor()
        {
            Speciality = "None";
        }

        public Doctor(string name, string address,string gender, string speciality, long mobileNo,long emergencyNo, int salary, DateTime joinDate):base(name, address,gender, mobileNo, emergencyNo, salary, joinDate)
        {
            /*Name = name;
            Address = address;*/
            Speciality = speciality;
            /*MobileNo = mobileNo;*/
            /*Patients = new ICollection<Patient>();
            Appointments = new List<Appointment>();*/
            /*Salary = salary;*/
        }
    }
}
