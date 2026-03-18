using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Booking.cs;

public class BookingDapperDataAccess
{
    private string connString = ConfigurationManager
    .ConnectionStrings["AppointmentsDB"].ConnectionString;

        public List<Booking> GetAllBookings(){ 
  
        using (var conn = new SqlConnection(connString)){ 
        
            return conn.Query<Booking>("SELECT * FROM Bookings ORDER BY LastName")
                       .ToList();
        }
        }
        public int InsertBooking(Booking Booking){
        using (var conn = new SqlConnection(connString)){
            string sql = @"INSERT INTO Bookings
                       (date, dentist, patient, reasonForAppt, priorityLevel)
                       VALUES (@date, @dentist, @patient, @reasonForAppt, @priorityLevel);
                       SELECT CAST(SCOPE_IDENTITY() AS INT);";

            int newId = conn.ExecuteScalar<int>(sql, Booking);
            return newId;
        }
        public int UpdateContact(Booking Booking){
        using (var conn = new SqlConnection(connString)){
            string sql = @"UPDATE Bookings SET
                        date = @date,
                        dentist = @dentist,
                        patient = @patient,
                        reasonForAppt = @reasonForAppt,
                        priorityLevel = @priorityLevel
                        WHERE BookingId = @BookingId";

            return conn.Execute(sql, Booking);
        }

        public int DeleteContact(int BookingId){
        using (var conn = new SqlConnection(connString)){
            string sql = "DELETE FROM Bookings WHERE BookingId = @Id";
            return conn.Execute(sql, new { Id = BookingId });
        }
        }



}










