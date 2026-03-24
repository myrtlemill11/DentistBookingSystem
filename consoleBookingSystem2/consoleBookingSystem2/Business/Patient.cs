using Newtonsoft.Json;
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
        [JsonProperty]
        private List<string> allergies = new List<string>();
        [JsonProperty]
        private List<string> medicalConditions = new List<string>();
        [JsonProperty]
        private Dentist dentist;
        [JsonProperty]
        private List<Booking> appointments = new List<Booking>();
        [JsonProperty]
        private DateTime DOB;
        [JsonProperty]
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

        // setter methods
        public void setDentist(Dentist d)
        {
            dentist = d;
        }

        public void setMedicalConditions(List<string> m)
        {
            medicalConditions = m;
        }

        public void setAppointments(List<Booking> a)
        {
            appointments = a;
        }

        public void setAllergies(List<string> a)
        {
            allergies = a;
        }

        public void setTypeOfPatient(string t)
        {
            typeOfPatient = t;
        }

        public void setDOB(DateTime d)
        {
            DOB = d;
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
                        // use change urgency rating depending on the booking and adding to the reason
            StringBuilder setReason = new StringBuilder();

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
                int count = 1;
                foreach (var pair in symptoms)
                {
                    Console.WriteLine($"\"{count}\" : \"{pair.Key}\"");
                    count++;
                }

                // get user response
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine(); // move to next line after key press
                string keyString = keyInfo.KeyChar.ToString();
                if (!int.TryParse(keyString, out int response))
                {
                    Console.WriteLine("Invalid selection.");
                    return;
                }

                // get symptom value from dictionary
                switch (int.Parse(keyString))
                {
                    case 1:
                        setReason.AppendLine("Broken filling with little sensitivity");
                        newBooking.setPriorityLevel(10);
                        break;
                    case 2:
                        setReason.AppendLine("Bleeding gums");
                        newBooking.setPriorityLevel(10);
                        break;
                    case 3:
                        setReason.AppendLine("Broken dentures");
                        newBooking.setPriorityLevel(10);
                        break;
                    case 4:
                        setReason.AppendLine("Loose or lost crown");
                        newBooking.setPriorityLevel(10);
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        return;
                }
            }
            else
            {
                Console.WriteLine("Please select the reason for your appointment from the following list by typing the value key:");
                int count = 1;
                foreach (var pair in treatments)
                {
                    Console.WriteLine($"\"{count}\" : \"{pair.Key}\"");
                    count++;
                }

                // get user response
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine(); // move to next line after key press
                string keyString = keyInfo.KeyChar.ToString();
                if (!int.TryParse(keyString, out int response))
                {
                    Console.WriteLine("Invalid selection.");
                    return;
                }


                // get treatment value from dictionary
                switch (int.Parse(keyString))
                {
                    case 1:
                        setReason.AppendLine("Cosmetic Dentistry");
                        newBooking.setPriorityLevel(treatments["Cosmetic Dentistry"]);
                        break;
                    case 2:
                        setReason.AppendLine("Dental Implants");
                        newBooking.setPriorityLevel(treatments["Dental Implants"]);
                        break;
                    case 3:
                        setReason.AppendLine("Dentures");
                        newBooking.setPriorityLevel(treatments["Dentures"]);
                        break;
                    case 4:
                        setReason.AppendLine("General Checkup");
                        newBooking.setPriorityLevel(treatments["General Checkup"]);
                        break;
                    case 5:
                        setReason.AppendLine("Root Canal Treatment");
                        newBooking.setPriorityLevel(treatments["Root Canal Treatments"]);
                        break;
                    case 6:
                        setReason.AppendLine("Teeth straightening");
                        newBooking.setPriorityLevel(treatments["Teeth straightening"]);
                        break;
                    case 7:
                        setReason.AppendLine("Tooth Extraction");
                        newBooking.setPriorityLevel(treatments["Tooth Extraction"]);
                        break;
                    case 8:
                        setReason.AppendLine("Tooth Whitening");
                        newBooking.setPriorityLevel(treatments["Tooth Whitening"]);
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        return;
                }

                // set dentist and patient for booking
                newBooking.setPatient(this);

                if (this.dentist != null)
                {
                    newBooking.setDentist(this.dentist);
                }
            }
            // ask user for further information
            Console.WriteLine("Please elaborate on symptoms present");
            string reason = Console.ReadLine();
            setReason.AppendLine(reason);

            // add reason to booking
            string reasonString = setReason.ToString();
            newBooking.setReason(reasonString);

            // set dentist and patient for booking
            newBooking.setPatient(this);

            if (this.dentist != null)
            {
                newBooking.setDentist(this.dentist);
            }

            // calculate priority level using reason and urgency


            // add booking to SQL Database
            SQLDAOImplementation database = new SQLDAOImplementation();
            database.InsertAppointment(newBooking); 
            }


        }


    }

}



}





