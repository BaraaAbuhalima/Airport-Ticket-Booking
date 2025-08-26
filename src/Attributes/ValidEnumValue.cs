namespace Airport_Ticket_Booking.Attributes;

using System;
using System.ComponentModel.DataAnnotations;

[AttributeUsage(AttributeTargets.Property|AttributeTargets.Field|AttributeTargets.Parameter)]
public class ValidEnumValueAttribute : ValidationAttribute
{
    private readonly Type _enumType;

    public ValidEnumValueAttribute(Type enumType)
    {
        if (!enumType.IsEnum)
            throw new ArgumentException("Type must be an enum.");
        _enumType = enumType;
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null || !Enum.IsDefined(_enumType, value))
        {
            return new ValidationResult($"Invalid value for {_enumType.Name}.");
        }
        return ValidationResult.Success;
    }
}
