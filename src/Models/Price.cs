using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Airport_Ticket_Booking.Attributes;
using Airport_Ticket_Booking.Enum;
using Airport_Ticket_Booking.ExtensionMethods;
using Airport_Ticket_Booking.Services;

namespace Airport_Ticket_Booking.Models;

public class Price:IComparable<Price>
{
    #region Properties
    
    [property: Required(ErrorMessage = "Currency Type is required")] 
    [property: ValidEnumValue(typeof(CurrencyTypeEnum))]
    public required CurrencyTypeEnum CurrencyTypeEnum { get; set; }
    
    [property: Required(ErrorMessage = "Price Amount is required")] 
    [property: Range(0,double.MaxValue,ErrorMessage = "Price Amount is required")] 
    public required double Amount { get; set; }

    #endregion
    
    #region Parameterless_Constructor

    public Price()
    {
    }

    #endregion

    #region Full_Parameterized_Constructor

    [SetsRequiredMembers]
    public Price(double amount, CurrencyTypeEnum currencyType)
    {
        Amount = amount;
        CurrencyTypeEnum = currencyType;
    }

    #endregion
    
    #region CompareTo
    
    public int CompareTo(Price? price)
    {
     
        ArgumentNullException.ThrowIfNull(price);
        return (Amount * CurrencyExchanger.ExchangeRate(CurrencyTypeEnum, price.CurrencyTypeEnum))
          .CompareTo(price.Amount*CurrencyExchanger.ExchangeRate(price.CurrencyTypeEnum,CurrencyTypeEnum));
    }
    #endregion


    #region Operator Comparison <, <=, >, >=
    public static bool operator <(Price left, Price right) => left.CompareTo(right) < 0;
    public static bool operator >(Price left, Price right) => left.CompareTo(right) > 0;
    public static bool operator <=(Price left, Price right) => left.CompareTo(right) <= 0;
    public static bool operator >=(Price left, Price right) => left.CompareTo(right) >= 0;

    #endregion
}
