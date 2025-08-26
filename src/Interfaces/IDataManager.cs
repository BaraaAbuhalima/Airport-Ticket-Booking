using Airport_Ticket_Booking.Models;
namespace Airport_Ticket_Booking.Interfaces;
public interface IDataManager<TKey,TValue> where TValue: IReservable<TKey>
{
    public IEnumerable<TValue> GetAll();
    public void Add(TValue item);
    public void AddAll(IEnumerable<TValue> items);
    public void Remove(TValue item);
    public TValue GetById(TKey id);
}