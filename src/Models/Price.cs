using System.Diagnostics.CodeAnalysis;

namespace Airport_Ticket_Booking.Models;

public class Price
{
    #region Properties

    public required string Currency { get; set; }
    public required double Amount { get; set; }

    #endregion

    #region Constructors

    #region Parameterless_Constructor

    public Price()
    {
    }

    #endregion

    #region Full_Parameterized_Constructor

    [SetsRequiredMembers]
    public Price(double amount, string currency)
    {
        Amount = amount;
        Currency = currency ?? throw new ArgumentNullException(nameof(currency));
    }

    #endregion

    #endregion
}