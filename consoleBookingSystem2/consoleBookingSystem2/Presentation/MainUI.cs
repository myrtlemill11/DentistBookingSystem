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

            int id = ReadInt("Enter Booking ID: ");
            int dentistId = ReadInt("Enter Dentist ID: ");
            int patientId = ReadInt("Enter Patient ID: ");
            DateTime date = ReadDate("Enter Date (yyyy-mm-dd): ");

            Booking booking = new Booking(id, dentistId, patientId, date);
            bookingManager.AddBooking(booking);

            Pause();
        }

        private void SearchBookingUI()
        {
            Console.Clear();
            Console.WriteLine("=== Search Booking ===");

            DateTime date = ReadDate("Enter Date (yyyy-mm-dd): ");

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

            int id = ReadInt("Enter Booking ID to cancel: ");

            bookingManager.CancelBooking(id);

            Pause();
        }

        private int ReadInt(string message)
        {
            int value;
            Console.Write(message);

            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid number. Try again: ");
            }

            return value;
        }

        private DateTime ReadDate(string message)
        {
            DateTime date;
            Console.Write(message);

            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.Write("Invalid date. Try again (yyyy-mm-dd): ");
            }

            return date;
        }

        private void Pause()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
