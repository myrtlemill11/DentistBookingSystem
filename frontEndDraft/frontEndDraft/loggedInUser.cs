using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontEndDraft
{
    internal class loggedInUser
    {
        string id;
        string password;

        //no arg constructor
        public loggedInUser()
        {

        }
        
        // set id
        public void setID(string id) 
        { 
            this.id = id; 
        }
        // set password
        public void setPassword(string password)
        {
            this.password = password;
        }
        // get id
        public string getID()
        {
            return this.id; 
        }
        // get password
        public string getPassword()
        {
            return password;
        }
    }
}
