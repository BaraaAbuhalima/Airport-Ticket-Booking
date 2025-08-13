using System.Diagnostics.CodeAnalysis;

namespace Airport_Ticket_Booking.Models;

public class User
{
    #region  Properties
    
    public required string  FirstName { get; set; }
    public required string  LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    #endregion
    
    #region  Constructors
    
    [SetsRequiredMembers]
    public User(string firstName, string lastName, string email, string phone)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
    }
    public User()
    {
    }
    #endregion
    
}