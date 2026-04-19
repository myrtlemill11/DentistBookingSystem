using System;
using System.Collections.Generic;
using System.IO;
using consoleBookingSystem2.Business.Models;

namespace consoleBookingSystem2.Business.Data
{
    public class FileStorage
    {
        private readonly string filePath = "bookings.txt";

        // Save a single booking to the file
        public void SaveBooking(Booking booking)
        {
            string line = $"{booking.BookingId},{booking.DentistId},{booking.PatientId},{booking.Date}";
            File.AppendAllText(filePath, line + Environment.NewLine);
        }

        // Export all bookings to the file (overwrite)
        public void ExportAll(List<Booking> bookings)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (var b in bookings)
                {
                    writer.WriteLine($"{b.BookingId},{b.DentistId},{b.PatientId},{b.Date}");
                }
            }
        }
    }
}
