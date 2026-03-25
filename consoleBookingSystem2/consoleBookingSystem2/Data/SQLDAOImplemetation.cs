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
        
        
        
        public List<Patient> GetAllPatients()
        {
            using (var conn = new SqlConnection(connString))
            {
                return conn.Query<Patient>("SELECT * FROM Patients").ToList();
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

        
        
        
        public int ConfirmAppointment(int id)
        {
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
            {
                string sql = "UPDATE Bookings SET status = 'Confirmed' WHERE BookingId = @Id";
                return conn.Execute(sql, new { Id = id });
            }
        }


        public List<Booking> viewAppointments()
        {

            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
            {

                return conn.Query<Booking>("SELECT * FROM Bookings ORDER BY date")
                           .ToList();
            }
        }


        
                public Dentist adminGetDentist(string ID)
        {
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
            {
                    // get all data fields of object to create dentist object to return
                    string sqlDentistId = "SELECT id FROM Users WHERE id = @id";
                    string dentistId = conn.QueryFirstOrDefault<string>(sqlDentistId, new { id = ID });

                    string sqlDentistPassword = "SELECT password FROM Users WHERE id = @id";
                    string dentistPassword = conn.QueryFirstOrDefault<string>(sqlDentistPassword, new { id = ID });

                    string sqlDentistFirstName = "SELECT firstName FROM Users WHERE id = @id";
                    string dentistFirstName = conn.QueryFirstOrDefault<string>(sqlDentistFirstName, new { id = ID });

                    string sqlDentistLastName = "SELECT lastName FROM Users WHERE id = @id";
                    string dentistLastName = conn.QueryFirstOrDefault<string>(sqlDentistLastName, new { id = ID });

                    string sqlDentistPhone = "SELECT phoneNumber FROM Users WHERE id = @id";
                    long dentistPhoneNumber = conn.QueryFirstOrDefault<long>(sqlDentistPhone, new { id = ID });

                    string sqlDentistEmail = "SELECT email FROM Users WHERE id = @id";
                    string dentistEmail = conn.QueryFirstOrDefault<string>(sqlDentistEmail, new { id = ID });

                    Dentist dentist = new Dentist();
                    dentist.setEmail(dentistEmail);
                    dentist.setFirstName(dentistFirstName);
                    dentist.setLastName(dentistLastName);
                    dentist.setPhoneNumber(dentistPhoneNumber);
                    dentist.setPassword(dentistPassword);
                    dentist.setId(dentistId);


                    return dentist;
                
            }
        }

        public List<string> adminViewAppointments()
        {
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
            {
                return conn.Query<string>("SELECT date, priorityLevel FROM Appointments")
                       .ToList();
            }    
        }

        public Booking viewAppointment(DateTime date)
{
    using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
    {

        string sqlDentist = "SELECT dentist FROM Appointments WHERE [date] = @date";
        string dentist = conn.QueryFirstOrDefault<string>(sqlDentist, new { date });

        string sqlPatient = "SELECT patient FROM Appointments WHERE [date] = @date";
        string patient = conn.QueryFirstOrDefault<string>(sqlPatient, new { date });

        string sqlDate = "SELECT date FROM Appointments WHERE [date] = @date";
        DateTime AppointmentDate = conn.QueryFirstOrDefault<DateTime>(sqlDate, new { date });

        string sqlReason = "SELECT reasonForAppointment FROM Appointments WHERE [date] = @date";
        string reason = conn.QueryFirstOrDefault<string>(sqlReason, new { date });

        string sqlPriority = "SELECT priorityLevel FROM Appointments WHERE [date] = @date";
        int priority = conn.QueryFirstOrDefault<int>(sqlPriority, new { date });

        Booking booking = new Booking();
        booking.setDate(AppointmentDate);
        booking.setReason(reason);
        booking.setPriorityLevel(priority);
        booking.setDentist(JsonConvert.DeserializeObject<Dentist>(dentist));
        booking.setPatient(JsonConvert.DeserializeObject<Patient>(patient));
        
        return booking;


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
            // get Json string of dentist object to store in database
            var dentistJson = Newtonsoft.Json.JsonConvert.SerializeObject(booking.getDentist());
            // get Json string of patient object to store in database
            var patientJson = Newtonsoft.Json.JsonConvert.SerializeObject(booking.getPatient());

            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
            {
                string sql = @"UPDATE Appointments SET
                date = @date
                WHERE
                reasonForAppointment = @reasonForAppointment and 
                priorityLevel = @priorityLevel";

                using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@date", booking.getDate());
                    cmd.Parameters.AddWithValue("@reasonForAppointment", booking.getReason());
                    cmd.Parameters.AddWithValue("@priorityLevel", booking.getPriorityLevel());
            
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

                public User getUser(string ID, string PASSWORD, string type)
        {
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
            {
                if (type == "dentist")
                {
                    // get all data fields of object to create object to return
                    string sqlDentistId = "SELECT id FROM Users WHERE id = @id and password = @password";
                    string dentistId = conn.QueryFirstOrDefault<string>(sqlDentistId, new { id = ID, password = PASSWORD });

                    string sqlDentistPassword = "SELECT password FROM Users WHERE id = @id and password = @password";
                    string dentistPassword = conn.QueryFirstOrDefault<string>(sqlDentistPassword, new { id = ID, password = PASSWORD });

                    string sqlDentistFirstName = "SELECT firstName FROM Users WHERE id = @id and password = @password";
                    string dentistFirstName = conn.QueryFirstOrDefault<string>(sqlDentistFirstName, new { id = ID, password = PASSWORD });

                    string sqlDentistLastName = "SELECT lastName FROM Users WHERE id = @id and password = @password";
                    string dentistLastName = conn.QueryFirstOrDefault<string>(sqlDentistLastName, new { id = ID, password = PASSWORD });

                    string sqlDentistPhone = "SELECT phoneNumber FROM Users WHERE id = @id and password = @password";
                    long dentistPhoneNumber = conn.QueryFirstOrDefault<long>(sqlDentistPhone, new { id = ID, password = PASSWORD });

                    string sqlDentistEmail = "SELECT email FROM Users WHERE id = @id and password = @password";
                    string dentistEmail = conn.QueryFirstOrDefault<string>(sqlDentistEmail, new { id = ID, password = PASSWORD });

                    Dentist dentist = new Dentist();
                    dentist.setEmail(dentistEmail);
                    dentist.setFirstName(dentistFirstName);
                    dentist.setLastName(dentistLastName);
                    dentist.setPhoneNumber(dentistPhoneNumber);
                    dentist.setPassword(dentistPassword);
                    dentist.setId(dentistId);


                    return dentist;
                }

                else if (type == "patient")
                {
                    // get all data fields of object to create object to return
                    string sqlPatientId = "SELECT id FROM Users WHERE id = @id and password = @password";
                    string patientId = conn.QueryFirstOrDefault<string>(sqlPatientId, new { id = ID, password = PASSWORD });

                    string sqlPatientPassword = "SELECT password FROM Users WHERE id = @id and password = @password";
                    string patientPassword = conn.QueryFirstOrDefault<string>(sqlPatientPassword, new { id = ID, password = PASSWORD });

                    string sqlPatientFirstName = "SELECT firstName FROM Users WHERE id = @id and password = @password";
                    string patientFirstName = conn.QueryFirstOrDefault<string>(sqlPatientFirstName, new { id = ID, password = PASSWORD });

                    string sqlPatientLastName = "SELECT lastName FROM Users WHERE id = @id and password = @password";
                    string patientLastName = conn.QueryFirstOrDefault<string>(sqlPatientLastName, new { id = ID, password = PASSWORD });

                    string sqlPatientPhone = "SELECT phoneNumber FROM Users WHERE id = @id and password = @password";
                    long patientPhoneNumber = conn.QueryFirstOrDefault<long>(sqlPatientPhone, new { id = ID, password = PASSWORD });

                    string sqlPatientEmail = "SELECT email FROM Users WHERE id = @id and password = @password";
                    string patientEmail = conn.QueryFirstOrDefault<string>(sqlPatientEmail, new { id = ID, password = PASSWORD });

                    Patient patient = new Patient();
                    patient.setEmail(patientEmail);
                    patient.setFirstName(patientFirstName);
                    patient.setLastName(patientLastName);
                    patient.setPhoneNumber(patientPhoneNumber);
                    patient.setPassword(patientPassword);
                    patient.setId(patientId);


                    return patient;
                }

                else if(type == "admin")
                {
                    // get all data fields of object to create object to return
                    string sqlAdminId = "SELECT id FROM Users WHERE id = @id and password = @password";
                    string adminId = conn.QueryFirstOrDefault<string>(sqlAdminId, new { id = ID, password = PASSWORD });

                    string sqlAdminPassword = "SELECT password FROM Users WHERE id = @id and password = @password";
                    string adminPassword = conn.QueryFirstOrDefault<string>(sqlAdminPassword, new { id = ID, password = PASSWORD });

                    string sqlAdminFirstName = "SELECT firstName FROM Users WHERE id = @id and password = @password";
                    string adminFirstName = conn.QueryFirstOrDefault<string>(sqlAdminFirstName, new { id = ID, password = PASSWORD });

                    string sqlAdminLastName = "SELECT lastName FROM Users WHERE id = @id and password = @password";
                    string adminLastName = conn.QueryFirstOrDefault<string>(sqlAdminLastName, new { id = ID, password = PASSWORD });

                    string sqlAdminPhone = "SELECT phoneNumber FROM Users WHERE id = @id and password = @password";
                    long adminPhoneNumber = conn.QueryFirstOrDefault<long>(sqlAdminPhone, new { id = ID, password = PASSWORD });

                    string sqlAdminEmail = "SELECT email FROM Users WHERE id = @id and password = @password";
                    string adminEmail = conn.QueryFirstOrDefault<string>(sqlAdminEmail, new { id = ID, password = PASSWORD });

                    Admin admin = new Admin();
                    admin.setEmail(adminEmail);
                    admin.setFirstName(adminFirstName);
                    admin.setLastName(adminLastName);
                    admin.setPhoneNumber(adminPhoneNumber);
                    admin.setPassword(adminPassword);
                    admin.setId(adminId);


                    return admin;
                }

                else
                {
                    return null;
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
        public int DeleteUser(string id)
        {
            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
            {
                string sql = "DELETE FROM Users WHERE id = @Id";
                return conn.Execute(sql, new { Id = id });
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

