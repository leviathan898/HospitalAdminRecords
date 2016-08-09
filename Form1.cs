using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace andyCheung_B8IT117
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //center current scope component
            LogIn li = new LogIn();
            li.ShowDialog();
            this.CenterToScreen();
        }

        private void btnPatientRecords_Click(object sender, EventArgs e)
        {
            //create and display new object of Patient Records form and show
            PatientRecords pr = new PatientRecords();
            pr.ShowDialog();
        }

        private void btnStaffRecords_Click(object sender, EventArgs e)
        {
            //create and display new object of Staff Records form and show
            StaffRecords sr = new StaffRecords();
            sr.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //exit program application
            LogIn li = new LogIn();
            li.ShowDialog();
        }

        private void grpButtons_Enter(object sender, EventArgs e)
        {

        }
    }
}
