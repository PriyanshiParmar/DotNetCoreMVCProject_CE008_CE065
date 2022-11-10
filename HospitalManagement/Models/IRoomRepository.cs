using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public interface IRoomRepository
    {
        //Add
        //Update
        //Delete
        //Get room details

        public Room AddRoom(Room room);
        public Room GetRoom(int roomNo);
        public Room UpdateRoom(Room roomChanges);
        public Room DeleteRoom(int roomNo);
    }
}
