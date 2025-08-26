using Airport_Ticket_Booking.AppConfig;
using Airport_Ticket_Booking.Interfaces;
using Airport_Ticket_Booking.Models;

namespace Airport_Ticket_Booking.Services;

public class FlightFileService:RepositoryFileService<int ,Flight>
{
    private  static readonly string ProjectRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../.."));
    private readonly string _filePath = Path.Combine(ProjectRoot,Configurator.GetConfigurations()["DataFiles:FlightsFilePath:source"]!);
    private readonly string _type = Configurator.GetConfigurations()["DataFiles:FlightsFilePath:type"]!;
 
    public FlightFileService(IFileService<Flight> fileService) : base(fileService)
    {
        Initialize(FileServiceFactory<Flight>.FileServiceFactories[_type](_filePath));
    }  
    public FlightFileService()
    {
        Initialize(FileServiceFactory<Flight>.FileServiceFactories[_type](_filePath));
    }
    
}