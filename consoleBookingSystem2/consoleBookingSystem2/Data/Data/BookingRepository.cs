using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using consoleBookingSystem2.Business.Models;

namespace consoleBookingSystem2.Data
{
    public class BookingRepository
    {
        private readonly string connectionString =
            "Server=localhost;Database=DentistBookingSystem;Trusted_Connection=True;";

        public void AddBooking(Booking booking)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Bookings (BookingId, DentistId, PatientId, Date)
                                 VALUES (@BookingId, @DentistId, @PatientId, @Date)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookingId", booking.BookingId);
                cmd.Parameters.AddWithValue("@DentistId", booking.DentistId);
                cmd.Parameters.AddWithValue("@PatientId", booking.PatientId);
                cmd.Parameters.AddWithValue("@Date", booking.Date);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Booking> GetAllBookings()
        {
            List<Booking> bookings = new List<Booking>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT BookingId, DentistId, PatientId, Date FROM Bookings";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bookings.Add(new Booking
                    {
                        BookingId = reader.GetInt32(0),
                        DentistId = reader.GetInt32(1),
                        PatientId = reader.GetInt32(2),
                        Date = reader.GetDateTime(3)
                    });
                }
            }

            return bookings;
        }

        public void DeleteBooking(int bookingId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Bookings WHERE BookingId = @BookingId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookingId", bookingId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
