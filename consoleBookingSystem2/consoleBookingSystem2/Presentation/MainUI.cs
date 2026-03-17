using System;
using consoleBookingSystem.Buisness;

namespace consoleBookingSystem.Presentation
{
    public class MainUI
    {
        public void start()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n==== Dental Booking System ====");
                Console.WriteLine("1. Dentist Login");
                Console.WriteLine("2. Patient Login");
                Console.WriteLine("3. Admin Login");
                Console.WriteLine("4. Exit");
                Console.Write("Select option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        dentistLogin();
                        break;

                    case "2":
                        patientLogin();
                        break;

                    case "3":
                        adminLogin();
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Exiting system...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        
        // Dentist
        private void dentistLogin()
        {
            Console.WriteLine("\n=== Dentist Login ===");

            Console.Write("Enter ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            // Dummy login (for now)
            if (id == "dentist" && password == "123")
            {
                Console.WriteLine("Login successful!");

                Dentist dentist = new Dentist();
                dentist.showDashboard();
            }
            else
            {
                Console.WriteLine("Invalid login details.");
            }
        }

        
        // Patient
        
        private void patientLogin()
        {
            Console.WriteLine("\n=== Patient Login ===");

            Console.Write("Enter ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            // Dummy login
            if (id == "patient" && password == "123")
            {
                Console.WriteLine("Login successful!");
                Console.WriteLine("Patient dashboard not implemented yet.");
            }
            else
            {
                Console.WriteLine("Invalid login details.");
            }
        }

        
        // Admin stuff
        
        private void adminLogin()
        {
            Console.WriteLine("\n=== Admin Login ===");

            Console.Write("Enter ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            // Dummy login
            if (id == "admin" && password == "123")
            {
                Console.WriteLine("Login successful!");
                Console.WriteLine("Admin dashboard not implemented yet.");
            }
            else
            {
                Console.WriteLine("Invalid login details.");
            }
        }
    }
}
