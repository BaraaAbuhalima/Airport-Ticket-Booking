using Airport_Ticket_Booking.Enum;
using Airport_Ticket_Booking.Models;

namespace Airport_Ticket_Booking.ExtensionMethods;

public static class FlightService
{
    public static IEnumerable<Flight> Search(this FlightRepository flightRepository, FlightCriteria criteria)
    {
        var flights = flightRepository.GetAll();
        return from flight in flights
            where (criteria.Id == null || flight.Id == criteria.Id)
            where (criteria.Arrival.Country == null || flight.Arrival.Country == criteria.Arrival.Country)
            where (criteria.Departure.Country == null || flight.Departure.Country == criteria.Departure.Country)
            where (criteria.Arrival.Name == null || flight.Arrival.Name == criteria.Arrival.Name)
            where (criteria.Departure.Name == null || flight.Departure.Name == criteria.Departure.Name)
            where (criteria.MinPrice == null || flight.Price >= criteria.MinPrice)
            where (criteria.MaxPrice == null || (flight.Price <= criteria.MaxPrice))
            where (criteria.FlightClass == null || flight.FlightClass == criteria.FlightClass)
            where (string.IsNullOrEmpty(criteria.FlightNumber) || flight.FlightNumber == criteria.FlightNumber)
            where (criteria.DepartureDate == default || flight.DepartureDate == criteria.DepartureDate)
            select flight;
    }
}

public class FlightCriteria()
{
  public  Price MinPrice;
  public Price MaxPrice;
  public int ?Id;
  public string FlightNumber;
  public Airport Departure;
  public Airport Arrival;
  public FlightClassEnum? FlightClass;
  public DateTime DepartureDate;
  
}