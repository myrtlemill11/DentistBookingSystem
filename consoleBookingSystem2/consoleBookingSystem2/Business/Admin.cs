using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBookingSystem.Buisness
{
    public class Admin : User
    {    
        protected List<Booking> appointments = new List<Booking>();
        // no arg constructor
        public Admin() { }

        // methods
        public void viewSchedule() {
        for (int i = 0; i < appointments.Count; i++){
        booking.getDate();
        booking.getDentist();
        booking.getPatient();
        booking.getPriorityLevel();
            }
        }

        public void viewDentistSchedule() {
         for (int i = 0;i < appointments.Count; i++) {
            if (booking.getDentist() == dentist){
                 booking.getDate();
                 booking.getDentist();
                 booking.getReason();
                 booking.getPriorityLevel();
            }
         }
        
        }
         public void reschedule(Booking booking, DateTime Newdate) {
         // we neeed setter methods in booking class to change the date of the booking
         Console.WriteLine(booking.getDate);
         Console.WriteLine("please write new date:");
         // booking.setDate(Newdate);
         Console.WriteLine("booking rescheduled to " + booking.getDate);
       }
       public void book() {
       new Booking();
       }
       public void cancel() {
       
       }
    }
}


