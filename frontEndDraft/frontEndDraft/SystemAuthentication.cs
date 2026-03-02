using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontEndDraft
{
    public partial class SystemAuthentication : Form
    {
        public SystemAuthentication()
        {
            InitializeComponent();
        }

        private void authenticate_Click(object sender, EventArgs e)
        {
            // send user email an authentication code that they can enter into the system
            User user = new User();
            string email = user.getEmail();
            string from = user.getEmail();
            MailMessage message = new MailMessage(from, email);
            message.Subject = "Authentication code";
            message.Body = "Authentication code is 1234";
            SmtpClient client = new SmtpClient();
        }
    }
}

