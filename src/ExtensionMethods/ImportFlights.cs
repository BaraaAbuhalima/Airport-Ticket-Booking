using Airport_Ticket_Booking.AttributesValidation;
using Airport_Ticket_Booking.Models;
using Airport_Ticket_Booking.Services;

namespace Airport_Ticket_Booking.ExtensionMethods;

public static class ImportFlightsService
{

    public static void ImportFlights(this FlightRepository flightRepository,string type , string filePath)
    {
     var flights=   FileServiceFactory<Flight>.FileServiceFactories[type](filePath).GetEnumerableData();
     List<List<string>> errors=[];
     foreach (var flight in flights)
     {
         errors.Add(FlightValidator.ValidateFlights(flight));
     }
     FlightRepository.GetInstance().AddList(flights);
     
    }
}