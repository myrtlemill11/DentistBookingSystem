using System;

namespace consoleBookingSystem.Buisness
{
    public class Booking
    {
        private Dentist dentist;
        private Patient patient;
        private DateTime date;
        private string reason;
        private int priorityLevel;

        public Booking(Dentist dentist, Patient patient, DateTime date, string reason, int priorityLevel)
        {
            this.dentist = dentist;
            this.patient = patient;
            this.date = date;
            this.reason = reason;
            this.priorityLevel = priorityLevel;
        }

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

        public void Print()
        {
            Console.WriteLine("Booking:");
            Console.WriteLine("Dentist: " + dentist.getName());
            Console.WriteLine("Patient: " + patient.getName());
            Console.WriteLine("Date: " + date);
           Console.WriteLine("Reason: " + reason);
            Console.WriteLine("Priority: " + priorityLevel);
        }
    }
}
