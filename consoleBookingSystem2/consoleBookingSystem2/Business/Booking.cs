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
        
        public Dentist Dentist { get; set; }
        public Patient Patient { get; set; }
        public DateTime Date { get; set; }
        public string ReasonForAppointment { get; set; }
        public int PriorityLevel { get; set; }
        
        
    }

}
