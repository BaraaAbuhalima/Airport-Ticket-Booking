using System.Globalization;
using Microsoft.Extensions.Configuration;

namespace Airport_Ticket_Booking.AppConfig;
public static class CultureConfigurator
{
    public static void ApplyCultureSettings(IConfigurationRoot config)
    {
        
        var cultureName = config["CultureSettings:Culture"] ?? "en-US";
        var longTimePattern = config["CultureSettings:LongTimePattern"]??"dd-MM-yyyy HH:mm:ss";
        var shortTimePattern = config["CultureSettings:ShortTimePattern"]??"dd-MM-yyyy";

        var culture = new CultureInfo(cultureName)
        {
            DateTimeFormat =
            {
                LongTimePattern = longTimePattern,
                ShortTimePattern = shortTimePattern
            }
        };
        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;
    }
}