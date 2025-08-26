using System;
using System.ComponentModel.DataAnnotations;

namespace Airport_Ticket_Booking.Attributes;

[AttributeUsage(AttributeTargets.Property|AttributeTargets.Field|AttributeTargets.Parameter)]
public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is DateTime dt && dt < DateTime.Now)
        {
            return new ValidationResult("Departure date must be today or in the future.");
        }
        return ValidationResult.Success;
    }
}
