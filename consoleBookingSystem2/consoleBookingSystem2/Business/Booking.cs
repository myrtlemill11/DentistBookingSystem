using System;
using System.Collections.Generic;
using consoleBookingSystem.Buisness;
using consoleBookingSystem.Buisness.DataStructures;
using consoleBookingSystem2.Business;

namespace consoleBookingSystem.Buisness
{
    public class BookingManager
    {
        private BookingLinkedList bookingList = new BookingLinkedList();
        private FileStorage storage = new FileStorage();

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
                    return b;
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

        public List<Booking> GetBookingsByDentist(int dentistId)
        {
            List<Booking> results = new List<Booking>();
            var allBookings = bookingList.GetAll();

            foreach (var b in allBookings)
            {
                if (b.DentistId == dentistId)
                    results.Add(b);
            }

            return results;
        }

        // Generate next ID
        public int GenerateNextBookingId()
        {
            var all = bookingList.GetAll();
            if (all.Count == 0)
                return 1;

            int max = 0;
            foreach (var b in all)
            {
                if (b.BookingId > max)
                    max = b.BookingId;
            }
            return max + 1;
        }

        // Load from file (not auto-called)
        public List<Booking> LoadFromFile()
        {
            return storage.LoadAll();
        }

        // Save all bookings
        public void SaveAll()
        {
            storage.SaveAll(bookingList.GetAll());
        }
    }
}
