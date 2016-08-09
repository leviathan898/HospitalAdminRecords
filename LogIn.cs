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
    public partial class LogIn : Form
    {
        HashCode hc = new HashCode();

        public LogIn()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "208512264222772174181102151942010236531331277169151";

            string user = txtUsername.Text;
            string pass = hc.PassHash(txtPassword.Text);

            if (user == username)
            {
                if (pass == password)
                {
                    Close();
                }

                else
                {
                    lblLogInDisplay.Text = "Invalid password. Please try again.";
                }
            }

            else
            {
                lblLogInDisplay.Text = "Invalid username. Please try again.";
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
