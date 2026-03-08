using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBookingSystem.Buisness
{
    internal class Admin : User
    {
        // no arg constructor
        public Admin() { }

        // methods
        public void viewSchedule() { }

        public void viewDentistSchedule() { }
        public void reschedule() { }
        public void book() { }
        public void cancel() { }
    }
}
