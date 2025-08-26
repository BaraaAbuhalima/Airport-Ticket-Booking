using Airport_Ticket_Booking.Models;
namespace Airport_Ticket_Booking.Interfaces;

public interface IReservable<out TKey>
{
    public TKey GetKey();

}

