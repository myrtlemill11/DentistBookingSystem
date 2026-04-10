using consoleBookingSystem2.Buisness;

namespace consoleBookingSystem2.Business.DataStructures
{
    public class BookingNode
    {
        public Booking Data { get; set; }
        public BookingNode Next { get; set; }

        public BookingNode(Booking data)
        {
            Data = data;
            Next = null;
        }
    }
}
