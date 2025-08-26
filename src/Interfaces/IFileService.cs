using Airport_Ticket_Booking.Models;
namespace Airport_Ticket_Booking.Interfaces;
public interface IFileService<TValue>
{
    public IEnumerable<TValue> GetEnumerableData();
    public void SaveEnumerableData( IEnumerable<TValue> enumerable);

}