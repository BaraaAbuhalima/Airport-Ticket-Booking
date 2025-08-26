namespace Airport_Ticket_Booking.Models;

public struct ContactInfo
{
   public string Email { get; set; }
   public string Phone { get; set; }

   public ContactInfo(string email, string phone)
   {
      this.Email = email;
      this.Phone = phone;
   }
}