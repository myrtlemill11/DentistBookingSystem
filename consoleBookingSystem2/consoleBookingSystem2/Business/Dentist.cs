using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consoleBookingSystem.Data;



namespace consoleBookingSystem.Buisness
{
    public class Dentist : User
    {
        // usage for sql database access
        SQLDAOImplementation dao = new SQLDAOImplementation();
        
        // data fields
        [JsonProperty]
        public string speciality;
        [JsonProperty]
        private Patient[] patients = new Patient[20];
        [JsonProperty]
        private List<Booking> appointments = new List<Booking>();
        private SQLDAOImplementation dao = new SQLDAOImplementation();


        // getter methods
        public Patient[] getPatients()
        {
            return patients;
        }

        public List<Booking> getAppointments()
        {
            return dao.viewAppointments();
        }



        public class Booking
        {
            public int BookingId { get; set; }
            public DateTime date { get; set; }
            public string dentist { get; set; }
            public string patient { get; set; }
            public string reasonForAppt { get; set; }
            public int priorityLevel { get; set; }
        }


        // setter methods
        public void setSpecialty(string s)
        {
            this.speciality = s;
        }
        
        // Dentist Dashboard Methods
        

        public void getDashboard()
        {
            bool loggedIn = true;

            while (loggedIn)
            {
                Console.WriteLine("\nDentist Dashboard");
                Console.WriteLine("1. View Appointments");
                Console.WriteLine("2. Confirm Appointment");
                Console.WriteLine("3. Cancel Appointment");
                Console.WriteLine("4. View Patients");
                Console.WriteLine("5. Logout");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        viewAppointments();
                        break;

                    case "2":
                        confirmAppointment();
                        break;

                    case "3":
                        Console.WriteLine("Enter an appointment to cancel:");
                        cancelAppointment(DateTime.Parse(Console.ReadLine()));
                        break;

                    case "4":
                        viewPatients();
                        break;

                    case "5":
                        loggedIn = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        private void viewAppointments()
        {
            List<Booking> bookings = getAppointments();

            foreach (Booking b in bookings)
            {
                Console.WriteLine("Date: " + b.date);
                Console.WriteLine("Reason: " + b.reasonForAppt);
                Console.WriteLine("Priority: " + b.priorityLevel);
            }
        }



        private void cancelAppointment(DateTime d)
        {
            Console.WriteLine("Enter appointment ID to cancel:");
            string id = Console.ReadLine();
            SQLDAOImplementation dao = new SQLDAOImplementation();
            dao.DeleteAppointment(d);
            Console.WriteLine("Appointment " + id + " cancelled.");
        }
        
        private void viewPatients()
        {
            Console.WriteLine("Viewing patients list...");
            List<Patient> patients = dao.dentistViewPatientData(this);

            foreach (var p in patients)
            {
                Console.WriteLine(p.getFirstName() + " " + p.getLastName());
            }

        }



        }

        
    }

