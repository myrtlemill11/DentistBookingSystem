using consoleBookingSystem.Buisness;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace consoleBookingSystem.Data
{
    public class SQLDAOImplementation : DAO
    {
        private string connString = ConfigurationManager
.ConnectionStrings["AppointmentsDB"].ConnectionString;

    public List<Booking> viewAppointments()
    {

        using (var conn = new SqlConnection(connString))
        {

            return conn.Query<Booking>("SELECT * FROM Bookings ORDER BY LastName")
                       .ToList();
        }
    }
    public int InsertAppointment(Booking Booking)
    {
        using (var conn = new SqlConnection(connString))
        {
            string sql = @"INSERT INTO Bookings
                   (date, dentist, patient, reasonForAppt, priorityLevel)
                   VALUES (@date, @dentist, @patient, @reasonForAppt, @priorityLevel);
                   SELECT CAST(SCOPE_IDENTITY() AS INT);";

            int newId = conn.ExecuteScalar<int>(sql, Booking);
            return newId;
        }
    }
    public int UpdateAppointment(Booking booking)
    {
        using (var conn = new SqlConnection(connString))
        {
            string sql = @"UPDATE Bookings SET
                    date = @date,
                    dentist = @dentist,
                    patient = @patient,
                    reasonForAppt = @reasonForAppt,
                    priorityLevel = @priorityLevel
                    WHERE BookingId = @BookingId";

            return conn.Execute(sql, booking);
        }
    }

    public int DeleteAppointment(int BookingId)
    {
        using (var conn = new SqlConnection(connString))
        {
            string sql = "DELETE FROM Bookings WHERE BookingId = @Id";
            return conn.Execute(sql, new { Id = BookingId });
        }
    }



}
    }
}
