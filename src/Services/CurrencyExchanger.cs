using Airport_Ticket_Booking.Enum;

namespace Airport_Ticket_Booking.Services;
public static class CurrencyExchanger
{
    #region Properties 
    private static readonly SortedDictionary<CurrencyTypeEnum, double> Rates = new()
    {
        {
            CurrencyTypeEnum.EUR, 1.17
        },
        {
            CurrencyTypeEnum.USD, 1
        },
        {
            CurrencyTypeEnum.GBP, 1.25
        },
        {
            CurrencyTypeEnum.JOD, 0.7
        },
        {
            CurrencyTypeEnum.NIS, 0.33
        }
    };
    #endregion
    
    #region ExchangeRate
    /// <summary>
    /// static method for the exchange rate between currencies 
    /// </summary>
    /// <param name="sourceCurrencyEnum">Currency to be changed</param>
    /// <param name="targetCurrencyEnum">Currency to be changed to</param>
    /// <returns> The exchange rate between the currencies </returns>
    public static double ExchangeRate(CurrencyTypeEnum sourceCurrencyEnum, CurrencyTypeEnum targetCurrencyEnum)
    {
        return  Rates[sourceCurrencyEnum] / Rates[targetCurrencyEnum];
    }
    #endregion 
}
