using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBookingSystem.Buisness
{
    public class Dentist : User
    {
        // data fields
        public string speciality;
        private Patient[] patients = new Patient[20];
        private List<Booking> appointments = new List<Booking>();

        // getter methods
        public Patient[] getPatients()
        {
            return patients;
        }
        public List<Booking> getAppointments()
        {
            return appointments;
        }

        public Booking getAppointment(Booking b)
        {
            return b;
        }
    }
}