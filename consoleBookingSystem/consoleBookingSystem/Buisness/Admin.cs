using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBookingSystem.Buisness
{
    internal class Admin : User
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
        for (int i = 0;i < appointments.Count; i++){
        if (booking.getDentist() == dentist){
        booking.getDate();
        booking.getDentist();
        booking.getReason();
        booking.getPriorityLevel();
        }
    }
        
        }
        public void reschedule() { }
        public void book() { }
        public void cancel() { }
    }
}


