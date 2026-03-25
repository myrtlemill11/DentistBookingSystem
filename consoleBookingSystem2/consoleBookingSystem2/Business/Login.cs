using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consoleBookingSystem.Data;


namespace consoleBookingSystem.Buisness
{
    public class Login
    {
        public SQLDAOImplementation dao = new SQLDAOImplementation();
        
        //no arg constructor
        public Login()
        {
            this.startUI();
        }

        public void startUI()
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
        public void adminLogin()
        {
            Console.WriteLine("\n=== Admin Login ===");

            Console.Write("Enter ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            User admin = new Admin();

            admin = dao.getUser(id, password, "admin");

            Console.WriteLine(admin.getId() + " " + admin.getPassword());

            try
            {
                // Dummy login
                if (id == admin.getId() && password == admin.getPassword())
                {
                    Console.WriteLine("Login successful!");
                    Console.WriteLine("Admin dashboard not implemented yet.");
                }
                else
                {
                    Console.WriteLine("Invalid login details.");
                }
            } catch (Exception e) 
            { 
                Console.WriteLine(e.ToString()); 
            }

        }

        public void patientLogin()
        {
                        Console.WriteLine("\n=== Patient Login ===");

            Console.Write("Enter ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            User patient = new Patient();

            patient = dao.getUser(id, password, "patient");


            // Dummy login
            if (id == patient.getId() && password == patient.getPassword())
            {
                Console.WriteLine("Login successful!");
                Console.WriteLine("Patient dashboard not implemented yet.");

            }
            else
            {
                Console.WriteLine("Invalid login details.");
            }

        }

        public void dentistLogin()
        {
                        Console.WriteLine("\n=== Dentist Login ===");

            Console.Write("Enter ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            User dentist = new Dentist();

            dentist = dao.getUser(id, password, "dentist");

            // Dummy login (for now)
            if (id == dentist.getId() && password == dentist.getPassword())
            {
                Console.WriteLine("Login successful!");

            }
            else
            {
                Console.WriteLine("Invalid login details.");
            }

        }
    }
}
