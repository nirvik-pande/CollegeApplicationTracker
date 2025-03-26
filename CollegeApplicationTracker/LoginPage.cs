using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CollegeApplicationTracker
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            string password = textBox2.Text;

            // Validate the username and password
            foreach (var account in Form1.userAccounts)
            {
                if (account.Username == username && account.Password == password)
                {
                    // Navigate to the Application Dashboard
                    Form2 applicationDashboard = new Form2();
                    applicationDashboard.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Invalid username or password. Please try again.");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to the Create Account page
            Form1 createAccountPage = new Form1();
            createAccountPage.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to the Forgot Password page
            ForgotPassword forgotPasswordPage = new ForgotPassword();
            forgotPasswordPage.Show();
            this.Hide();
        }
    }
}
