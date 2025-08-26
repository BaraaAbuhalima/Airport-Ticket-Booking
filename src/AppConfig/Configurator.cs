using System.Globalization;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace Airport_Ticket_Booking.AppConfig;

public static class Configurator
{
    private static IConfigurationRoot Configuration { get; set; } = LoadConfigurations();
    
    #region ApplyConfigurations
    public static void ApplyConfigurations()
    {
        CultureConfigurator.ApplyCultureSettings(Configuration);
    }
    #endregion

    #region LoadConfigurations
    public static IConfigurationRoot LoadConfigurations()
    {
        return new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
    }
    #endregion
    
    #region GetConfigurations
    public static IConfigurationRoot GetConfigurations()
    {
        if (Configuration is null)
        {
          return  Configuration=LoadConfigurations();
        }
        return Configuration;
    }
    #endregion
}