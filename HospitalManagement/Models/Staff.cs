namespace HospitalManagementSystem.Models
{
    public abstract class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public long MobileNo { get; set; }
        public long EmergencyNo { get; set; }
        public int Salary { get; set; }
        public DateTime JoinDate { get; set; }

        public Staff() { }
        public Staff(string name, string address, string gender, long mobileNo, long emergencyNo, int salary, DateTime joinDate)
        {
            Name = name;
            Address = address;
            Gender = gender;
            MobileNo = mobileNo;
            EmergencyNo = emergencyNo;
            Salary = salary;
            JoinDate = joinDate;
            /*Room = room;
            RoomNo = Room.RoomNo;*/
        }
    }
}
