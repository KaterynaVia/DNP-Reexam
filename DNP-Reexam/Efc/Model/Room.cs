using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Efc.Model;

public class Room
{
    [Key]
    public int RoomId { get; set; }
    public string Theme { get; set; }
    public int FloreNum { get; set; }
    public int RoomNum { get; set; }
    public double PricePerNight { get; set; }
    public int NumberOfBeds { get; set; }
    public bool HasSpa { get; set; }
    
    [ForeignKey("Reservation")]
    public int IdReservation { get; set; }
    public Reservation Reservation { get; set; }
}