namespace Airport_Ticket_Booking.Models;

public class Booking
{
    public string PNR { get; set; }
    public DateTime BookingDate { get; set; }
    public User User { get; set; }
    public ContactInfo ContactInfo { get; set; }
    public Flight Flight { get; set; }
}