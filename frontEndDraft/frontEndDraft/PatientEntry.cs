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
    public partial class PatientEntry : Form
    {
        public PatientEntry()
        {
            InitializeComponent();
        }


        private void returningPatient_Click_1(object sender, EventArgs e)
        {
            PatientLogin patientLogin = new PatientLogin();
            patientLogin.Show();
        }
    }
}
