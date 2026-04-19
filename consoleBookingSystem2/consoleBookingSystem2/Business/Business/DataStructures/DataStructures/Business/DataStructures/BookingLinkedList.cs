using System.Collections.Generic;
using consoleBookingSystem2.Business.Models;

namespace consoleBookingSystem2.Business.DataStructures
{
    public class BookingLinkedList
    {
        private BookingNode head;

        public void Add(Booking booking)
        {
            var newNode = new BookingNode(booking);
            if (head == null)
            {
                head = newNode;
                return;
            }

            BookingNode current = head;
            while (current.Next != null)
                current = current.Next;

            current.Next = newNode;
        }

        public bool Remove(int bookingId)
        {
            if (head == null) return false;

            if (head.Data.BookingId == bookingId)
            {
                head = head.Next;
                return true;
            }

            BookingNode current = head;
            while (current.Next != null && current.Next.Data.BookingId != bookingId)
                current = current.Next;

            if (current.Next == null) return false;

            current.Next = current.Next.Next;
            return true;
        }

        public Booking Find(int bookingId)
        {
            BookingNode current = head;
            while (current != null)
            {
                if (current.Data.BookingId == bookingId)
                    return current.Data;
                current = current.Next;
            }
            return null;
        }

        public List<Booking> GetAll()
        {
            List<Booking> bookings = new List<Booking>();
            BookingNode current = head;
            while (current != null)
            {
                bookings.Add(current.Data);
                current = current.Next;
            }
            return bookings;
        }
    }
}
