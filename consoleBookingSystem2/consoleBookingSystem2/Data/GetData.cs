using consoleBookingSystem.Buisness;
using consoleBookingSystem.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBookingSystem2.Data
{
    public class GetData
    {
        // get access to sql database
        SQLDAOImplementation dao = new SQLDAOImplementation();
        public GetData()
        {

        }
        public void RandomiseUserData()
        {
            Random rand = new Random();
            List<string> firstNames = new List<string> { "John", "Jane", "Michael", "Emily", "David" };
            List<string> lastNames = new List<string> { "Smith", "Johnson", "Brown", "Taylor", "Anderson" };
            List<string> id = new List<string> { "12345", "67890", "54321", "98765", "24680" };
            List<string> password = new List<string> { "password1", "password2", "password3", "password4", "password5" };
            List<long> phoneNumber = new List<long> { 5551234, 5555678, 5559012, 5553456, 5557890 };
            List<string> email = new List<string> { "user@example.com", "user2@mail.com", "user3@test.com", "user4@demo.com", "user5@sample.com" };

            // randomise admin data
            for (int i = 0; i < 5; i++)
            {
                Admin admin = new Admin();
                admin.setFirstName(firstNames[rand.Next(firstNames.Count)]);
                admin.setLastName(lastNames[rand.Next(lastNames.Count)]);
                admin.setId(id[rand.Next(id.Count)]);
                admin.setPassword(password[rand.Next(password.Count)]);
                admin.setEmail(email[rand.Next(email.Count)]);
                admin.setPhoneNumber(phoneNumber[rand.Next(phoneNumber.Count)]);

                // place admin in database
                dao.insertUser(admin);
            }

            // randomise patient data
            for (int i = 0; i < 5; i++)
            {
                Patient patient = new Patient();
                patient.setFirstName(firstNames[rand.Next(firstNames.Count)]);
                patient.setLastName(lastNames[rand.Next(lastNames.Count)]);
                patient.setId(id[rand.Next(id.Count)]);
                patient.setPassword(password[rand.Next(password.Count)]);
                patient.setEmail(email[rand.Next(email.Count)]);
                patient.setPhoneNumber(phoneNumber[rand.Next(phoneNumber.Count)]);
                
                // place patient in database
                dao.insertUser(patient);

            }

            // randomise dentist data
            for (int i = 0; i < 5; i++)
            {
                Dentist dentist = new Dentist();
                dentist.setFirstName(firstNames[rand.Next(firstNames.Count)]);
                dentist.setLastName(lastNames[rand.Next(lastNames.Count)]);
                dentist.setId(id[rand.Next(id.Count)]);
                dentist.setPassword(password[rand.Next(password.Count)]);
                dentist.setEmail(email[rand.Next(email.Count)]);
                dentist.setPhoneNumber(phoneNumber[rand.Next(phoneNumber.Count)]);

                // place dentist in database
                dao.insertUser(dentist);
            }
        }
    }
}

