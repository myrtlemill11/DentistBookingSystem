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

        // setter methods
        public void setDate(DateTime d)
        {
            date = d;
        }
        public void setPatient(Patient p)
        {
            patient = p;
        }

        public void setDentist(Dentist d)
        {
            dentist = d;
        }

        public void setReason(string r)
        {
            reasonForAppointment = r;
        }

        public void setPriorityLevel(int p)
        {
            priorityLevel = p;
        }
    }

}
