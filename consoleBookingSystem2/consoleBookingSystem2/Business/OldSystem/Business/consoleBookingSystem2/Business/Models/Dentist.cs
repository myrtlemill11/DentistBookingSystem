using System;
using System.Collections.Generic;

namespace consoleBookingSystem2.Business.Models
{
    public class Dentist : User
    {
        public List<Booking> Bookings { get; set; } = new List<Booking>();

        public Dentist(int id, string username, string password, string name)
            : base(id, username, password, name)
        {
        }

        public void AddBooking(Booking booking)
        {
            Bookings.Add(booking);
        }

        public override string ToString()
        {
            return $"Dentist ID: {Id}, Name: {Name}";
        }
    }
}
