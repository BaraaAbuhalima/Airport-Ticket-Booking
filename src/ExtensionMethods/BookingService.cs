using Airport_Ticket_Booking.Enum;
using Airport_Ticket_Booking.Models;

namespace Airport_Ticket_Booking.ExtensionMethods;

public static class BookingService
{
    public static IEnumerable<Booking> Search(this BookingRepository bookingRepository, BookingCriteria criteria)
    {
        var bookings = bookingRepository.GetAll();
        var flights=FlightRepository.GetInstance().GetAll();
        return from booking in bookings
            join flight in flights on booking.FlightId equals flight.Id
            where (criteria.Id == null || booking.Id == criteria.Id)
            where (criteria.ArrivalCountry == null || flight.Arrival.Country == criteria.ArrivalCountry)
            where (criteria.DepartureCountry == null || flight.Departure.Country == criteria.DepartureCountry)
            where (criteria.ArrivalAirport == null || flight.Arrival.Name== criteria.ArrivalAirport)
            where (criteria.DepartureAirport == null || flight.Departure.Name == criteria.DepartureAirport)
            where (criteria.Price == null || (flight.Price == criteria.Price))
            where (criteria.FlightClass == null || flight.FlightClass == criteria.FlightClass)
            where (string.IsNullOrEmpty(criteria.FlightNumber) || flight.FlightNumber == criteria.FlightNumber)
            where (criteria.DepartureDate == default || flight.DepartureDate == criteria.DepartureDate)
            where (criteria.FlightNumber==null||flight.FlightNumber==criteria.FlightNumber)
            where (criteria.UserId==null||(booking.UserId==criteria.UserId))
            select booking;
    }
}

public class BookingCriteria()
{
    public Price Price;
    public int ?Id;
    public string FlightNumber;
    public string DepartureCountry;
    public string DepartureAirport;
    public string ArrivalCountry;
    public string ArrivalAirport;
    public FlightClassEnum? FlightClass;
    public DateTime DepartureDate;
    public int? UserId;

}
   