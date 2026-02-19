using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontEndDraft
{
    public partial class PatientLogin : Form
    {
        User[] users = new User[3];
        
        // no arg constructor
        public PatientLogin()
        {
            // add users (example)
            User user1 = new User("123", "password");
            this.users[0] = user1;
            User user2 = new User("234", "password1");
            this.users[1] = user2;
            User user3 = new User("345", "password2");
            this.users[2] = user3;

            InitializeComponent();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{
        //}

        private void PatientLogin_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //retrieve submitted data
            string id = ID_number.Text;
            string password = insertPassword.Text;
            // stop loop when user found
            User foundUser = null;
            //check if user exists already
            for (int i = 0; i < users.Length; i++)
            {
                if (id == users[i].getID())
                {
                    // if user exists, check password
                    if (password == users[i].getPassword())
                    {
                        SystemAuthentication authentication = new SystemAuthentication();
                        authentication.Show();
                        
                          
                        //return users[i];
                    }

                    // give feedback
                    else
                    {
                        feedback.AppendText("Incorrect password, please try again");
                    }
                }
            }
            //return foundUser;
        }

        //private void ID_number_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void insertPassword_TextChanged(object sender, EventArgs e)
        //{

        //}


    }
}
