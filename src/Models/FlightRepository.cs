using System.Collections;
using System.Text.Json;
using Airport_Ticket_Booking.AppConfig;

namespace Airport_Ticket_Booking.Models;
public class FlightRepository :Repository<Flight>
{
    private static FlightRepository? _flightRepository;

    private FlightRepository()
    {
    }
    public static FlightRepository GetInstance()
    {
        if (_flightRepository == null)
            _flightRepository = new FlightRepository();
        return _flightRepository;
    }
}
