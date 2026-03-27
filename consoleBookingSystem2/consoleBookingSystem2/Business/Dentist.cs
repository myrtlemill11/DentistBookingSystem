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
                        cancelAppointment();
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
                Console.WriteLine("Date: " + b.getDate());
                Console.WriteLine("Reason: " + b.getReason());
                Console.WriteLine("Priority: " + b.getPriorityLevel());
            }
        }



        private void confirmAppointment()
        {
            Console.WriteLine("Enter appointment ID to confirm:");
            int id = int.Parse(Console.ReadLine());

            dao.ConfirmAppointment(id);   // ✅ calls database

            Console.WriteLine("Appointment confirmed.");
        }


        private void cancelAppointment()
        {
            Console.WriteLine("Enter appointment ID to cancel:");
            int id = int.Parse(Console.ReadLine());

            dao.DeleteAppointment(id);   //

            Console.WriteLine("Appointment cancelled.");
        }
        
        private void viewPatients()
        {
            var patients = dao.dentistViewPatientData(this);

            foreach (var p in patients)
            {
                Console.WriteLine(p.getFirstName() + " " + p.getLastName());
            }
        }



        }

        
    }
