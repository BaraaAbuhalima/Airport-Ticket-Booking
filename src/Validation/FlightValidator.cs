using System.ComponentModel.DataAnnotations;
using Airport_Ticket_Booking.Models;

namespace Airport_Ticket_Booking.AttributesValidation;

using System.ComponentModel.DataAnnotations;

public static class FlightValidator
{
    public static List<string> ValidateFlights(Flight flight)
    {
        var context = new ValidationContext(flight);
        var results = new List<ValidationResult>();

        Validator.TryValidateObject(
            flight, context, results, validateAllProperties: true);

        var errors = results.Select(r => r.ErrorMessage ?? "Unknown error").ToList();

        return errors;
    }
}
