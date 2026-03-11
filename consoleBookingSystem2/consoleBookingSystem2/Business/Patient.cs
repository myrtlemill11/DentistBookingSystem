using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBookingSystem.Buisness
{
    public class Patient : User
    {
        // data fields
        private List<string> allergies = new List<string>();
        private List<string> medicalConditions = new List<string>();
        private Dentist dentist;
        private List<Booking> appointments = new List<Booking>();
        private DateTime DOB;
        private string typeOfPatient;

        // getter methods
        public Dentist getDentist()
        {
            return dentist;
        }

        public List<string> getMedicalConditions()
        {
            return medicalConditions;
        }
        public List<Booking> getAppointments()
        {
            return appointments;
        }

        public Booking getAppointment(Booking b)
        {
            return b;
        }

        public List<string> getAllergies()
        {
            return allergies;
        }

        public string getTypeOfPatient()
        {
            return typeOfPatient;
        }

        // methods to change/add bookings
        public void requestCancellation()
        {

        }

        public void bookAppointment()
        {

        }


    }
}