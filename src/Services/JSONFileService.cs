using System.Text.Json;
using Airport_Ticket_Booking.Helper;
using Airport_Ticket_Booking.Interfaces;

namespace Airport_Ticket_Booking.Services;

public class JsonFileService<TItem>: IFileService<TItem>
{
    private readonly string _filePath;

    public JsonFileService(string filePath)
    {
        _filePath = filePath;
    }
    public IEnumerable<TItem> GetEnumerableData()
    {
        var data = FileReadWriteHelper.ReadFile(_filePath);
        try
        {
            return JsonSerializer.Deserialize<List<TItem>>(data) ?? [];
        }
        catch (Exception _)
        {
            return [];
        }
    }
    public void SaveEnumerableData(IEnumerable<TItem> enumerable)
    {
        var data = JsonSerializer.Serialize(enumerable);
        FileReadWriteHelper.WriteFile(_filePath, data);
  
    }


}