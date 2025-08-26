using Airport_Ticket_Booking.Interfaces;

namespace Airport_Ticket_Booking.Models;

public class Booking : IReservable<int>
{
    #region Properties

    public int Id => GetHashCode(); 
    public DateTime BookingDate { get; set; }
    public int UserId { get; set; }
    public ContactInfo ContactInfo { get; set; }
    public int FlightId { get; set; }
    
    
    // public Price Price { get; set; }
    #endregion
    
    #region Constructor
    public Booking(int flightId, DateTime bookingDate, int userId, ContactInfo contactInfo)
    {
     
        FlightId = flightId;
        BookingDate = bookingDate;
        UserId = userId;
        ContactInfo = contactInfo;

    }
    #endregion  
    public int GetKey() => FlightId;

}