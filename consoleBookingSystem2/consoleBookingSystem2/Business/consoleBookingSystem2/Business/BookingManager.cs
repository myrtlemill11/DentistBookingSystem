using System;
using System.Collections.Generic;
using consoleBookingSystem2.Business.Models;
using consoleBookingSystem2.Business.DataStructures;

namespace consoleBookingSystem2.Business
{
    public class BookingManager
    {
        private BookingLinkedList bookingList = new BookingLinkedList();
        private FileStorage storage = new FileStorage();
        private Logger logger = new Logger();   // logging support

        public void AddBooking(Booking booking)
        {
            bookingList.Add(booking);
            logger.Write($"Added booking {booking.BookingId}");
            Console.WriteLine("Booking added successfully!");
        }

        public void CancelBooking(int bookingId)
        {
            bool removed = bookingList.Remove(bookingId);
            logger.Write(removed
                ? $"Cancelled booking {bookingId}"
                : $"Failed to cancel booking {bookingId}");
            Console.WriteLine(removed ? "Booking cancelled." : "Booking not found.");
        }

        public Booking SearchByDate(DateTime date)
        {
            var allBookings = bookingList.GetAll();
            foreach (var b in allBookings)
            {
                if (b.Date == date)
                {
                    logger.Write($"Searched booking by date {date}");
                    return b;
                }
            }
            logger.Write($"No booking found on {date}");
            return null;
        }

        public void ViewBookings()
        {
            var allBookings = bookingList.GetAll();
            if (allBookings.Count == 0)
            {
                Console.WriteLine("No bookings found.");
                logger.Write("Viewed bookings: none found");
                return;
            }

            foreach (var b in allBookings)
            {
                Console.WriteLine(
                    $"Booking ID: {b.BookingId}, Dentist: {b.DentistId}, Patient: {b.PatientId}, Date: {b.Date}"
                );
            }

            logger.Write("Viewed all bookings");
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

            logger.Write($"Viewed bookings for dentist {dentistId}");
            return results;
        }

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

        public List<Booking> LoadFromFile()
        {
            logger.Write("Loaded bookings from file");
            return storage.LoadAll();
        }

        public void SaveAll()
        {
            storage.SaveAll(bookingList.GetAll());
            logger.Write("Saved all bookings to file");
        }

        public bool IsBookingIdInUse(int bookingId)
        {
            var all = bookingList.GetAll();
            foreach (var b in all)
            {
                if (b.BookingId == bookingId)
                    return true;
            }
            return false;
        }

        public bool HasBookingOnDate(int dentistId, DateTime date)
        {
            var all = bookingList.GetAll();
            foreach (var b in all)
            {
                if (b.DentistId == dentistId && b.Date == date)
                    return true;
            }
            return false;
        }
    }
}
