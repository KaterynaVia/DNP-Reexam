using System.ComponentModel.DataAnnotations;

namespace Efc.Model;

public class Reservation
{
    [Key]
    public int IdReservation { get; set; }
    [Required]
    [MaxLength(100)]
    public string GuestName { get; set; }
    public DateTime CheckinDate { get; set; }
    public int NumberOfNights { get; set; }
    public bool IncludeBreakfast { get; set; }
    public ICollection<Room> Rooms { get; set; }
    
    
}