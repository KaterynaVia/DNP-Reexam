using Efc.DataAccess;
using Efc.Model;

namespace Efc;

public class Program
{
    public static void Main(string[] args)
    {
        HotelContext app = new HotelContext();
        Room r = new Room()
        {
            FloreNum = 1,
            HasSpa = true,
          
            NumberOfBeds = 2,
            PricePerNight = 100,
            RoomId = 100,
            RoomNum = 20,
            Theme = "castle"
        };
        Room room2 = new Room()
        {
            FloreNum = 1,
            HasSpa = true,
           
            NumberOfBeds = 2,
            PricePerNight = 100,
            RoomId = 110,
            RoomNum = 20,
            Theme = "castle"
        };
        Room room3 = new Room()
        {
            FloreNum = 1,
            HasSpa = true,
            
            NumberOfBeds = 2,
            PricePerNight = 100,
            RoomId = 120,
            RoomNum = 20,
            Theme = "castle"
        };
        Reservation reservation1 = new Reservation()
        {
            IdReservation = 20,
            CheckinDate = new DateTime(2024,5,5),
            GuestName = "Hugo",
            IncludeBreakfast = true,
            NumberOfNights = 5


        };
        Reservation reservation2 = new Reservation()
        {
            IdReservation = 21,
            CheckinDate = new DateTime(2024,5,5),
            GuestName = "HugoM",
            IncludeBreakfast = true,
            NumberOfNights = 5


        };
        Reservation reservation3 = new Reservation()
        {
            IdReservation = 22,
            CheckinDate = new DateTime(2024,5,5),
            GuestName = "HugoS",
            IncludeBreakfast = true,
            NumberOfNights = 5


        };
        List<Reservation> room1 = new List<Reservation>();
        room1.Add(reservation1);
    }
}