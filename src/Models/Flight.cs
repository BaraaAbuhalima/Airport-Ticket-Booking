using Airport_Ticket_Booking.Enum;

namespace Airport_Ticket_Booking.Models;

public record Flight(string FlightNumber, Price Price, Airport Departure, Airport Arrival,FlightClassEnum  FlightClass);
