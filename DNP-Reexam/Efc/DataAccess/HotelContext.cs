using Efc.Model;
using Microsoft.EntityFrameworkCore;

namespace Efc.DataAccess;

public class HotelContext:DbContext
{
    public DbSet<Room>  Rooms {get;set;}
    public DbSet<Reservation> Reservations { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = App.db");
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Room>().HasKey(r => r.RoomId);
        modelBuilder.Entity<Reservation>().HasKey(dr => dr.IdReservation);
        
    }  

}