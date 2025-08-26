using System.ComponentModel.DataAnnotations;

namespace Airport_Ticket_Booking.Models;

public record Airport(
    [property: Required(ErrorMessage = "Airport name is required")]
    string Name,

    [property: Required(ErrorMessage = "Country is required")]
    string Country
);