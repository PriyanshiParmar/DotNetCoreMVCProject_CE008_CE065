using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Patient
    {
        //private static int patients = 1000;
        [Key]
        public int Id { get; set; }
        
        public ICollection<Appointment>? Appointments { get; set; }
        public string Name { get; set; }
        public string Disease { get; set; }
        public string Address { get; set; }
        public long MobileNo { get; set; }
        public ICollection<Prescription>? PrescriptionsGiven { get; set; }
        public string Condition { get; set; }
        public DateTime? AdmitDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public long AmountPaid { get; set; }
        public Room? Room { get; set; }
        public int? RoomId { get; set; }
        public Doctor? Doctor { get; set; }
        public int DoctorId { get; set; }
        
        //Prescription 
        //Condition
        //admitDate
        //checkoutDate
        //roomNo
        //Doctor associated
                    //list of reports
        //mobileNo
        //Bills
        //Total Amount paid
        public Patient() 
        {
            
        }
        public Patient(string name, string disease, string address, long mobileNo, string condition, Doctor doctor,int doctorId, long amountPaid)
        {
            Name = name;
            Disease = disease;
            Address = address;
            MobileNo = mobileNo;
            Condition = condition;
            /*Appointments = new List<Appointment>();
            BillsGiven = new List<Bill>();
            PrescriptionsGiven = new List<Prescription>();
            DoctorsGiven = new List<Doctor>();*/
            Doctor = doctor;
            DoctorId = doctorId;
            AmountPaid = amountPaid;
        }
        public Patient(string name, string disease, string address, long mobileNo, string condition, DateTime? admitDate, DateTime? dischargeDate, long amountPaid, int? roomId, int doctorId)
        {
            
            //Appointments = appointments;
            Name = name;
            Disease = disease;
            Address = address;
            MobileNo = mobileNo;
            //PrescriptionsGiven = prescriptionsGiven;
            //BillsGiven = billsGiven;
            Condition = condition;
            AdmitDate = admitDate;
            DischargeDate = dischargeDate;
            AmountPaid = amountPaid;
            //Room = room;
            RoomId = roomId;
            //Doctor = doctor;
            DoctorId = doctorId;
        }
    }
}
