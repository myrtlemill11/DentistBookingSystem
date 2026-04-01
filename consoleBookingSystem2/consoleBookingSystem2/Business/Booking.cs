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
        // private fields 
        private Dentist dentist;
        private Patient patient;
        private DateTime date;
        private string reason;
        private int priorityLevel;

        // getters
        public Dentist getDentist()
        {
            return dentist;
        }

        public Patient getPatient()
        {
            return patient;
        }

        public DateTime getDate()
        {
            return date;
        }

        public string getReason()
        {
            return reason;
        }

        public int getPriorityLevel()
        {
            return priorityLevel;
        }

        // setters
        public void setDentist(Dentist d)
        {
            dentist = d;
        }

        public void setPatient(Patient p)
        {
            patient = p;
        }

        public void setDate(DateTime d)
        {
            date = d;
        }

        public void setReason(string r)
        {
            reason = r;
        }

        public void setPriorityLevel(int p)
        {
            priorityLevel = p;
        }
    }
}
