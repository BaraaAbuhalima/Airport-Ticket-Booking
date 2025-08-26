using Airport_Ticket_Booking.AppConfig;
using Airport_Ticket_Booking.Interfaces;
using Airport_Ticket_Booking.Models;
using Airport_Ticket_Booking.Services;
namespace Airport_Ticket_Booking.Services;
public class BookingFileService:RepositoryFileService<int ,Booking>
{
    private  static readonly string ProjectRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../.."));
    private readonly string _filePath = Path.Combine(ProjectRoot,Configurator.GetConfigurations()["DataFiles:BookingsFilePath:source"]!);
    private readonly string _type = Configurator.GetConfigurations()["DataFiles:BookingsFilePath:type"]!;
    public BookingFileService(IFileService<Booking> fileService):base(fileService)
    {
        Initialize(FileServiceFactory<Booking>.FileServiceFactories[_type](_filePath));
    }
    public BookingFileService()
    {
        Initialize(FileServiceFactory<Booking>.FileServiceFactories[_type](_filePath));
    }
}