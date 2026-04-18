using System;

namespace consoleBookingSystem2.Business
{
    // Represents a single booking in the system
    public class Booking
    {
        public int BookingId { get; set; }
        public int DentistId { get; set; }
        public int PatientId { get; set; }
        public DateTime Date { get; set; }

        public Booking(int bookingId, int dentistId, int patientId, DateTime date)
        {
            BookingId = bookingId;
            DentistId = dentistId;
            PatientId = patientId;
            Date = date;
        }

        public override string ToString()
        {
            return $"Booking ID: {BookingId}, Dentist: {DentistId}, Patient: {PatientId}, Date: {Date}";
        }
    }
}
