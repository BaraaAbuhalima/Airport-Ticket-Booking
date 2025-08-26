namespace Airport_Ticket_Booking.Models;

public class BookingRepository : Repository<Booking>
{
    private static BookingRepository? _bookingRepository;

    private BookingRepository()
    {
    }
    public static BookingRepository GetInstance()
    {
        if (_bookingRepository == null)
            _bookingRepository = new BookingRepository();
        return _bookingRepository;
    }
}