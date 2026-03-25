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
        
        private Dentist dentist;
        private Patient patient;
        

        // getter methods
        
        
        public DateTime Date { get; set; }
        public string ReasonForAppointment { get; set; }
        public int PriorityLevel { get; set; }

        public Patient getPatient()
        {
            return patient;
        }

        

        public Dentist getDentist()
        {
            return dentist;
        }

        

        

        // setter methods
        
        public void setPatient(Patient p)
        {
            patient = p;
        }

        public void setDentist(Dentist d)
        {
            dentist = d;
        }

        

        
    }

}
