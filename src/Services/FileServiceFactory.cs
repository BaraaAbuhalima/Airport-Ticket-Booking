using System.Collections.ObjectModel;
using Airport_Ticket_Booking.ExtensionMethods;
using Airport_Ticket_Booking.Interfaces;
using Airport_Ticket_Booking.Models;

namespace Airport_Ticket_Booking.Services;

public static class FileServiceFactory<T>where T:IReservable<int>
{
    public static ReadOnlyDictionary<string,Func<string,IFileService<T>>>FileServiceFactories  { get; } =
        new ReadOnlyDictionary<string, Func<string,IFileService<T>>>(
            new Dictionary<string, Func<string,IFileService<T>>>
            {
                { "json", (filePath=>new JsonFileService<T>(filePath))},
                { "cvs", (filePath=>new CsvFileService<T>(filePath))},
            });
}