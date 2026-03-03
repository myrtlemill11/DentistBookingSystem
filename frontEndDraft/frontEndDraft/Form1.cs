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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void patient_Click(object sender, EventArgs e)
        {
            PatientEntry PatientEntry = new PatientEntry();
            patientLogin.WindowState = FormWindowState.Maximized;
            PatientEntry.Show();
        }

        private void staff_Click(object sender, EventArgs e)
        {
            // go into form that has two buttons, one for admin and one for dentist
            // for dentist button, open console
        }
    }
}


