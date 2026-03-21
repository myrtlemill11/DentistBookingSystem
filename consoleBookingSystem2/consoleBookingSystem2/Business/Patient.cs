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
        private string id;

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
            // get user input for date of appointment to cancel
            Console.WriteLine("Please enter the date of the appointment you wish to cancel (dd/mm/yyyy)");
            DateTime findAppointmentDate = DateTime.Parse(Console.ReadLine());
            // find appointment in SQL database and cancel it
        }

        public void bookAppointment()
        {
            // create list of symptoms for user to select from
            Dictionary<string, int> symptoms = new Dictionary<string, int>();
            symptoms.Add("Broken filling with little sensitivity", 10);
            symptoms.Add("Bleeding gums", 10);
            symptoms.Add("Broken dentures", 10);
            symptoms.Add("Loose or lost crown", 10);

            // create list of treatments for user to select from
            Dictionary<string, int> treatments = new Dictionary<string, int>();
            treatments.Add("Cosmetic Dentistry", 2);
            treatments.Add("Dental Implants", 4);
            treatments.Add("Dentures", 5);
            treatments.Add("General Checkup", 1);
            treatments.Add("Root Canal Treatment", 9);
            treatments.Add("Teeth straightening", 4);
            treatments.Add("Tooth Extraction", 7);
            treatments.Add("Tooth Whitening", 2);
            // create new booking object
            Booking newBooking = new Booking();

            // ask user if appointment is urgent
            Console.WriteLine("Is your appointment urgent? (y/n)");
            string userResponse = Console.ReadLine()?.Trim().ToLower();

            if (userResponse == "y" || userResponse == "yes")
            {
                Console.WriteLine("Please select the reason for your appointment from the following list by typing the value key:");
                foreach (var pair in symptoms)
                {    
                    Console.WriteLine($"\"{pair.Key}\" : \"{pair.Value}\"");
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine(); // move to next line after key press
                string keyString = keyInfo.KeyChar.ToString();
                if (!int.TryParse(keyString, out int response))
                {
                    Console.WriteLine("Invalid selection.");
                    return;
                }
                // use change urgency rating depending on the booking and adding to the reason
                newBooking.setPriorityLevel(1); // high rating due to urgent appointment
                StringBuilder s = new StringBuilder();
                s.AppendLine(symptoms[int.Parse(keyString)]);

                // ask user for further information
                Console.WriteLine("Please elaborate on symptoms present");
                string reason = Console.ReadLine();
                s.AppendLine(reason);

                // add reason to booking
                string reasonString = s.ToString();
                newBooking.setReason(reasonString);

                // set dentist and patient for booking
                newBooking.setPatient(this);

                if (this.dentist != null)
                {
                    newBooking.setDentist(this.dentist);
                }
                // send to admin to determine date/ AI?? / dentist

                // ask user if happy with appt time
            }
            else
            {

            }

// present user with dropdown list of symptoms
Console.WriteLine("Please select the reason for your appointment from the following list by typing the value key:");
// ...
        }


    }

}





