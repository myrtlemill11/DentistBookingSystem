using System;

namespace consoleBookingSystem2.Business
{
    public class BookingManager
    {
        private Booking[] bookings = new Booking[200];
        private int count = 0;

        public void AddBooking(Booking booking)
        {
            bookings[count] = booking;
            count++;
        }

        public Booking SearchByDate(DateTime date)
        {
            for (int i = 0; i < count; i++)
            {
                if (bookings[i].getDate() == date)
                {
                    return bookings[i];
                }
            }
            return null;
        }
    }
}
