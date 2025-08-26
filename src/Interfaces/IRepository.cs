using Airport_Ticket_Booking.Models;
namespace Airport_Ticket_Booking.Interfaces;

public interface IRepository<TKey,TValue> where TValue: IReservable<TKey>
{
    public IEnumerable<TValue> GetAll();
    public void Add(TValue model);
    public void AddList(IEnumerable<TValue> models);
    public void Remove(TValue model);
    public TValue GetById(int id);
}