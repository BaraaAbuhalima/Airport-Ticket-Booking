using Airport_Ticket_Booking.Interfaces;

namespace Airport_Ticket_Booking.Services;

public abstract  class RepositoryFileService<TKey,TItem>:IDataManager<TKey,TItem> where TItem:IReservable<TKey>
{
    private IFileService<TItem>? FileService { get; set; }
    protected RepositoryFileService(IFileService<TItem> fileService)
    {
        FileService = fileService;
    }

    protected RepositoryFileService() {}
    protected void Initialize (IFileService<TItem> fileService)
    {
        FileService = fileService;
    }
    public IEnumerable<TItem> GetAll()
    {
      return  FileService.GetEnumerableData();
    }

    public void Add(TItem item)
    {
        var itemsList=GetAll().ToList();
        itemsList.Add(item);
        FileService.SaveEnumerableData(itemsList);
    }

    public void AddAll(IEnumerable<TItem> items)
    {
       var itemList= this.GetAll().Union(items);
       FileService.SaveEnumerableData(itemList);

    }


    public void Remove(TItem item)
    {
        var itemsList=GetAll().ToList();
        itemsList.RemoveAll((_) => _.GetKey().Equals(item.GetKey()));
        foreach (var item1 in itemsList)
        {
            Console.WriteLine(item1);
        }
        FileService.SaveEnumerableData(itemsList);
    }

    public TItem GetById(TKey id)
    {
     return  GetAll().First((item)=>item.GetKey().Equals(id));
    }
}