using Newtonsoft.Json;
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
    public class SQLDAOImplementation
    {
        private string connString = ConfigurationManager
.ConnectionStrings["AppointmentsDB"].ConnectionString;

        public List<Booking> viewAppointments()
        {

            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
            {

                return conn.Query<Booking>("SELECT * FROM Bookings ORDER BY date")
                           .ToList();
            }
        }
        public int InsertAppointment(Booking Booking)
        {
        // get Json string of dentist object to store in database
        var dentistJson = Newtonsoft.Json.JsonConvert.SerializeObject(Booking.getDentist());
        // get Json string of patient object to store in database
        var patientJson = Newtonsoft.Json.JsonConvert.SerializeObject(Booking.getPatient());
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
            {
                string sql = @"INSERT INTO Bookings
                   (date, dentist, patient, reasonForAppt, priorityLevel)
                   VALUES (@date, @dentist, @patient, @reasonForAppt, @priorityLevel);
                   SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    
                int newId = conn.ExecuteScalar<int>(sql, new 
                {
                    date = Booking.getDate(),
                    dentist = Booking.getDentist().getId(), 
                    patient = Booking.getPatient().getId(),
                    reasonForAppt = Booking.getReason(),
                    priorityLevel = Booking.getPriorityLevel()
                });
                return newId;
            }
        }
        public int UpdateAppointment(Booking booking)
        {
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
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
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
            {
                string sql = "DELETE FROM Bookings WHERE BookingId = @Id";
                return conn.Execute(sql, new { Id = BookingId });
            }
        }
        public int InsertPatient(Patient patient)
        {
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
            {
                string sql = @"INSERT INTO Patients
                   (allergies, medicalConditions, dentist,appointments, DOB, typeOfPatient, id)
                   VALUES (@allergies, @medicalConditions, @dentist, @appointments, @DOB, @typeOfPatient, @id);
                   SELECT CAST(SCOPE_IDENTITY() AS INT);";
                int newId = conn.ExecuteScalar<int>(sql, patient);
                return newId;


            }
        }
        public int DeletePatient(int id)
        {
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
            {
                string sql = "DELETE FROM Patients WHERE id = @Id";
                return conn.Execute(sql, new { Id = id });
            }
        }
        public int assignPatient(Patient patient, Dentist dentist)
        {
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
            {
                string sql = @"UPDATE Patients SET
                    dentist = @dentist
                    WHERE id = @id";
                return conn.Execute(sql, new { dentist = dentist, id = patient.getId() });
            }
            }
        }

        public int insertUser(User user)
        {
        using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
        {
            string sql = @"INSERT INTO Users
               (firstName, lastName, id, password, email, phoneNumber)
               VALUES (@firstName, @lastName, @id, @password, @email, @phoneNumber);
               SELECT CAST(SCOPE_IDENTITY() AS INT);";
            int newId = conn.ExecuteScalar<int>(sql, new
            {
                firstName = user.getFirstName(),
                lastName = user.getLastName(),
                id = user.getId(),
                password = user.getPassword(),
                email = user.getEmail(),
                phoneNumber = user.getPhoneNumber(),
            });
            return newId;


        }

    }
         
        public List<string> viewUsers()
        {

            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
            {

                return conn.Query<string>("SELECT * FROM Users ORDER BY id")
                .ToList();
            }
        }

    }

