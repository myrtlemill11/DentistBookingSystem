using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consoleBookingSystem.Data;



namespace consoleBookingSystem.Buisness
{
    public class Admin : User
    {    

        // use for editing bookings in the database
        SQLDAOImplementation dao = new SQLDAOImplementation();
        
        [JsonProperty]
        protected List<Booking> appointments = new List<Booking>();
        // no arg constructor
        public Admin() { }

        // methods
        public void viewSchedule() {
            Console.Write(string.Join(" ,", dao.adminViewAppointments()));
        }

        // get dashboard for using functions
public void getDashboard() {
    // set int value for input
    int input = 0;

    // present user options
    Console.WriteLine("Admin Dashboard");
    Console.WriteLine("Select an option by typing the numerical value:");
    Console.WriteLine("1. View Schedule");
    Console.WriteLine("2. View Dentist Schedule");
    Console.WriteLine("3. Reschedule Appointment");
    Console.WriteLine("4. Cancel Appointment");
    Console.WriteLine("5. Exit");

    // get user response and call appropriate method
    try
    {
      input = int.Parse(Console.ReadLine());
    } catch (Exception e) 
    { 
        Console.WriteLine("Please try again"); 
        getDashboard();
    }

    switch (input)
    {
        case 1:
            viewSchedule();
            break;

        case 2:
            viewDentistSchedule();
            break;

        case 3:
            Console.WriteLine("Enter booking date to reschedule:");
            try
            {
                DateTime d = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter new date:");
                DateTime newDate = DateTime.Parse(Console.ReadLine());

                reschedule(dao.viewAppointment(d), newDate);

            }
            catch (Exception e)
            {
                Console.WriteLine("Please try again");
                getDashboard();
            }
            break;

        case 4:
            Console.WriteLine("Enter an appointment to cancel:");
            cancel(DateTime.Parse(Console.ReadLine()));
            break;
        case 5:
            Console.WriteLine("Exiting system...");
            break;

        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }



}
        public void viewDentistSchedule() 
        {
            Console.WriteLine("Enter dentist id:");
            string idDentist = Console.ReadLine();
            try
            {
                Dentist dentist = dao.adminGetDentist(idDentist);
                Console.Write(string.Join(", " , dao.viewDentistAppointments(dentist)));
            } catch (Exception e) 
            {
                Console.WriteLine("Please try again");
                getDashboard();
            }
        }
         public void reschedule(Booking booking, DateTime Newdate) {
         // we neeed setter methods in booking class to change the date of the booking
         Console.WriteLine(booking.getDate());
         Console.WriteLine("please write new date:");
         booking.setDate(Newdate);
         Console.WriteLine("booking rescheduled to " + booking.getDate());
       }
       public void book() {
       new Booking();
       }
       public void cancel(DateTime d)
       {
            SQLDAOImplementation dao = new SQLDAOImplementation();
            dao.DeleteAppointment(d);
       }

    }
}


