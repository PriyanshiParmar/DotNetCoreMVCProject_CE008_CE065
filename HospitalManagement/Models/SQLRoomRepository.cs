using HospitalManagementSystem.Models;

namespace HospitalManagement.Models
{
    public class SQLRoomRepository: IRoomRepository
    {
        private readonly AppDbContext context;
        public SQLRoomRepository(AppDbContext context)
        {
            this.context = context;
        }

        Room IRoomRepository.AddRoom(Room room)
        {
            context.Rooms.Add(room);
            context.SaveChanges();
            return room;
        }

        Room IRoomRepository.DeleteRoom(int roomNo)
        {
            Room room = context.Rooms.Find(roomNo);
            if(room != null)
            {
                context.Rooms.Remove(room);
                context.SaveChanges();
            }
            return room;
        }

        Room IRoomRepository.GetRoom(int roomNo)
        {
            Room room = context.Rooms.Find(roomNo);
            return room;
        }

        Room IRoomRepository.UpdateRoom(Room roomChanges)
        {
            var room = context.Rooms.Attach(roomChanges);
            room.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return roomChanges;
        }
    }
}
