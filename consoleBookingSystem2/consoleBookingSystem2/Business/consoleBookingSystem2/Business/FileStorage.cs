using System;
using System.Collections.Generic;
using System.IO;

namespace consoleBookingSystem2.Business
{
    public class FileStorage
    {
        private string filePath = "bookings.txt";

        public void SaveAll(List<Booking> bookings)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var b in bookings)
                    {
                        writer.WriteLine($"{b.BookingId},{b.DentistId},{b.PatientId},{b.Date}");
                    }
                }
            }
            catch { }
        }

        public List<Booking> LoadAll()
        {
            List<Booking> list = new List<Booking>();

            if (!File.Exists(filePath))
                return list;

            try
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        int id = int.Parse(parts[0]);
                        int dentist = int.Parse(parts[1]);
                        int patient = int.Parse(parts[2]);
                        DateTime date = DateTime.Parse(parts[3]);

                        list.Add(new Booking(id, dentist, patient, date));
                    }
                }
            }
            catch { }

            return list;
        }
    }
}
