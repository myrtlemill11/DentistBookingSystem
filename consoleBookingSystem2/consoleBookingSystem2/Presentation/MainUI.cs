using System;
using consoleBookingSystem.Buisness;

namespace consoleBookingSystem.Presentation
{
    public class MainUI
    {
        private BookingManager bookingManager = new BookingManager();
        private Login log = new Login();

        public void Start()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("===== Dentist Booking System =====");
                Console.WriteLine("1. Add Booking");
                Console.WriteLine("2. View All Bookings");
                Console.WriteLine("3. Search Booking by Date");
                Console.WriteLine("4. Cancel Booking");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBookingUI();
                        break;

                    case "2":
                        bookingManager.ViewBookings();
                        Pause();
                        break;

                    case "3":
                        SearchBookingUI();
                        break;

                    case "4":
                        CancelBookingUI();
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        Pause();
                        break;
                }
            }
        }

        private void AddBookingUI()
        {
            Console.Clear();
            Console.WriteLine("=== Add Booking ===");

            Console.Write("Enter Booking ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Dentist ID: ");
            int dentistId = int.Parse(Console.ReadLine());

            Console.Write("Enter Patient ID: ");
            int patientId = int.Parse(Console.ReadLine());

            Console.Write("Enter Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Booking booking = new Booking(id, dentistId, patientId, date);
            bookingManager.AddBooking(booking);

            Pause();
        }

        private void SearchBookingUI()
        {
            Console.Clear();
            Console.WriteLine("=== Search Booking ===");

            Console.Write("Enter Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Booking result = bookingManager.SearchByDate(date);

            if (result != null)
            {
                Console.WriteLine($"Booking Found: ID {result.BookingId}, Dentist {result.DentistId}, Patient {result.PatientId}, Date {result.Date}");
            }
            else
            {
                Console.WriteLine("No booking found on that date.");
            }

            Pause();
        }

        private void CancelBookingUI()
        {
            Console.Clear();
            Console.WriteLine("=== Cancel Booking ===");

            Console.Write("Enter Booking ID to cancel: ");
            int id = int.Parse(Console.ReadLine());

            bookingManager.CancelBooking(id);

            Pause();
        }

        private void Pause()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
