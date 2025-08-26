using System.Data;
using Airport_Ticket_Booking.AppConfig;
using Airport_Ticket_Booking.Models;
using System.Linq;
using Airport_Ticket_Booking.Enum;
using Airport_Ticket_Booking.ExtensionMethods;
using Airport_Ticket_Booking.Services;

namespace Airport_Ticket_Booking;
// What is 
public static class Program
{
    private static void Main(string[] args)
    {
        var flightFileService = new FlightFileService();
        var flightRepository = FlightRepository.GetInstance();
        var bookingRepository = BookingRepository.GetInstance();
        var bookingFileService = new BookingFileService();
        bookingRepository.SetDataManager(bookingFileService);
        flightRepository.SetDataManager(flightFileService);
        flightRepository.Add(new Flight("fdf", new Price(10.2, CurrencyTypeEnum.EUR), new Airport("fdf", "fdf"),
            new Airport("fdfd", "dff"), new DateTime(), FlightClassEnum.Business));
        Console.WriteLine("Hello, World!");
        bookingRepository.Add(new Booking(1, new DateTime(), 1, new ContactInfo()
        {
            Email = "dffdf",
            Phone = "dfsf"
        }));
        dynamic baraa=null;
        baraa.gjdlkd();


    }
    public static void Run<T>(this  T value) where  T : Generic
    {
        if (typeof(T) == typeof(SecondType))
        {
            // Handle Email that exists in SecondType
        }
    }

}

public class Generic
{
}

public class SecondType
{
}




