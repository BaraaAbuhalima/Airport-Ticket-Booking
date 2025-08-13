using System.Globalization;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace Airport_Ticket_Booking.AppConfig;

public static class Configurator
{
    #region ApplyConfigurations
    
    public static void ApplyConfigurations()
    {
        var config = LoadConfigurationJson();
        CultureConfigurator.ApplyCultureSettings(config);
    }
    #endregion

    #region LoadConfigurationJson
    
    private static IConfigurationRoot LoadConfigurationJson()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        
        return config;
    }
    #endregion
}