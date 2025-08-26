using Airport_Ticket_Booking.Interfaces;

namespace Airport_Ticket_Booking.Models;

public abstract class Repository<TValue>:IRepository<int,TValue> where TValue : IReservable<int>
{
    private IDataManager<int, TValue> _dataManager { get; set; } 

    public IDataManager<int, TValue> SetDataManager(IDataManager<int, TValue> dataManager)
    {
        return _dataManager=dataManager;
    }
    public IEnumerable<TValue> GetAll()
    {
        return _dataManager.GetAll();
    }
    public void Add(TValue item)
    {
        _dataManager.Add(item);
    }

    public void AddList(IEnumerable<TValue> models)
    {
        _dataManager.AddAll(models);
    }

    public void Remove(TValue item)
    {
        _dataManager.Remove(item);
    }
    
    public TValue GetById(int id)
    {
        Console.WriteLine("dfdsfdsf");
        return _dataManager.GetById(id);
    }
}