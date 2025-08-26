using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Airport_Ticket_Booking.Attributes;
using Airport_Ticket_Booking.Enum;
using Airport_Ticket_Booking.Interfaces;

namespace Airport_Ticket_Booking.Models;

public record Flight(
    [property: Required(ErrorMessage = "Flight number is required")]
    [property: StringLength(10,MinimumLength = 5,ErrorMessage = "Flight number cannot exceed 10 characters")]
    
    string FlightNumber,
    [property: Required(ErrorMessage = "Price is required")]
    Price Price,

    [property: Required(ErrorMessage = "Departure airport is required")]
    Airport Departure,

    [property: Required(ErrorMessage = "Arrival airport is required")]
    Airport Arrival,

    [property: Required(ErrorMessage = "Departure date is required")]
    [FutureDate]
    DateTime DepartureDate,

    [property: Required(ErrorMessage = "Flight class is required")]
    FlightClassEnum FlightClass
) : IReservable<int>
{
    public int Id => GetHashCode();
    public int GetKey() => Id;
}
