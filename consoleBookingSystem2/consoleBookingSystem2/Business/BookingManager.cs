using System;
using System.Collections.Generic;
using consoleBookingSystem2.Business.Models;
using consoleBookingSystem2.Business.DataStructures;

namespace consoleBookingSystem2.Business
{
    public class BookingManager
    {
        private BookingLinkedList bookingList = new BookingLinkedList();

        public void AddBooking(Booking booking)
        {
            bookingList.Add(booking);
            Console.WriteLine("Booking added successfully!");
        }

        public void CancelBooking(int bookingId)
        {
            bool removed = bookingList.Remove(bookingId);
            Console.WriteLine(removed ? "Booking cancelled." : "Booking not found.");
        }

        public Booking SearchByDate(DateTime date)
        {
            var allBookings = bookingList.GetAll();
            foreach (var b in allBookings)
            {
                if (b.Date == date)
                {
                    return b;
                }
            }
            return null;
        }

        public void ViewBookings()
        {
            var allBookings = bookingList.GetAll();
            if (allBookings.Count == 0)
            {
                Console.WriteLine("No bookings found.");
                return;
            }

            foreach (var b in allBookings)
            {
                Console.WriteLine(
                    $"Booking ID: {b.BookingId}, Dentist: {b.DentistId}, Patient: {b.PatientId}, Date: {b.Date}"
                );
            }
        }
    }
}
