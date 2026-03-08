using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBookingSystem.Buisness
{
    public abstract class User
    {
        // no arg constructor
        public User() { }
        // data fields
        private string firstName;
        private string lastName;
        private string id;
        private string password;
        private string email;
        private long phoneNumber;

        // get methods
        public string getFirstName()
        {
            return firstName; 
        }

        public string getLastName()
        {
            return lastName;
        }
        public string getId()
        {
            return id;
        }
        public string getEmail()
        {
            return email;
        }
        public long getPhoneNumber()
        {
            return phoneNumber;
        }

        // setter methods
        public void setFirstName(string s)
        {
            firstName = s;
        }

        public void setLastName(string s)
        {
            lastName = s;
        }

        public void setId(string s)
        {
            id = s;
        }

        public void setEmail(string s)
        {
            email = s;
        }
        public void setPhoneNumber(long p)
        {
            phoneNumber = p;
        }

        // view dashboard
        public void viewDashboard()
        {
            
        }
    }
}   
