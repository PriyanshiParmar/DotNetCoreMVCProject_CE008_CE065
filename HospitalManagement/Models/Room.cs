using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Room
    {
        [Key]
        public int RoomNo { get; set; }
        public string RoomType { get; set; }
        public int NoOfBeds { get; set; }
        public int VacantBeds { get; set; }

        public ICollection<Patient>? Patients { get; set; }

        public Room() { }
        public Room(int roomNo, string roomType, int noOfBeds, int vacantBeds)
        {
            RoomNo = roomNo;
            RoomType = roomType;
            NoOfBeds = noOfBeds;
            VacantBeds = vacantBeds;
            /*Patients = patients;*/
        }
    }
}
