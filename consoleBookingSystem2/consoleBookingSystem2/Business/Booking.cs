using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBookingSystem.Buisness
{
    public class Booking
    {
        // data fields
        private DateTime date;
        private Dentist dentist;
        private Patient patient;
        private string reasonForAppointment;
        private int priorityLevel;

        // getter methods
        public DateTime getDate()
        {
            return date;
        }

        public Dentist getDentist()
        {
            return dentist;
        }

        public string getReason()
        {
            return reasonForAppointment;
        }

        public int getPriorityLevel()
        {
            return priorityLevel;
        }
    }
}