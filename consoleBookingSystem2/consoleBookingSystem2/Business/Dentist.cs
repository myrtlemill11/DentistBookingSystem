using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBookingSystem.Buisness
{
    public class Dentist : User
    {
        // data fields
        public string speciality;
        private Patient[] patients = new Patient[20];
        private List<Booking> appointments = new List<Booking>();

        // getter methods
        public Patient[] getPatients()
        {
            return patients;
        }

        public List<Booking> getAppointments()
        {
            return appointments;
        }

        public Booking getAppointment(Booking b)
        {
            return b;
        }

        
        // Dentist Dashboard Methods
        

        public void showDashboard()
        {
            bool loggedIn = true;

            while (loggedIn)
            {
                Console.WriteLine("\n=== Dentist Dashboard ===");
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
            Console.WriteLine("Viewing appointments...");
        }

        private void confirmAppointment()
        {
            Console.WriteLine("Enter appointment ID to confirm:");
            string id = Console.ReadLine();

            Console.WriteLine("Appointment " + id + " confirmed.");
        }

        private void cancelAppointment()
        {
            Console.WriteLine("Enter appointment ID to cancel:");
            string id = Console.ReadLine();

            Console.WriteLine("Appointment " + id + " cancelled.");
        }

        private void viewPatients()
        {
            Console.WriteLine("Viewing patients list...");
        }
    }
}
