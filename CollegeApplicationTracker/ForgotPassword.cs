using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeApplicationTracker
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to the Login page without a message
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string email = textBox3.Text;

            // Add logic to handle email submission
            // For example, send an email with reset instructions

            MessageBox.Show("An email with reset instructions has been sent to " + email);

            // Navigate to the Login page
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
    }
}
