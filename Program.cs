using Airport_Ticket_Booking.AppConfig;
namespace Airport_Ticket_Booking;

public static class Program
{
  private static void Main(string[] args)
    {
        Configurator.ApplyConfigurations();
        Console.WriteLine("Hello, World!");
    }
}