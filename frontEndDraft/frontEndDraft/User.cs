using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontEndDraft
{
    internal class User
    {
        public User(string id, string password)
        {
            this.id = id;
            this.password = password;
        }
        // login details
        string id { get; set; }
        string password { get; set; }
        string dentist { get; set; }

        // getter methods
        public string getID()
        {
            return id; 
        }
        public string getPassword()
        { 
            return password; 
        }


    }
}
