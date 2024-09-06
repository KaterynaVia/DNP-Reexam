using Efc.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Efc.DataAccess;

public class DataAccess
{
    public HotelContext Context { get; set; }

    public DataAccess(HotelContext hotelContext)
    {
        Context = hotelContext;
    }
    public async Task<Room> CreateRoomAsync(Room room)
    {
        EntityEntry<Room> newRoom = await Context.Rooms.AddAsync(room);
        await Context.SaveChangesAsync();
        return newRoom.Entity;
    
    }
 
}