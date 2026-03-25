using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBookingSystem2.Business
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

        }

        public void patientLogin()
        {
        }

        public void dentistLogin()
        {
        }
    }
}
