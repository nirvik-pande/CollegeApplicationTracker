using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CollegeApplicationTracker
{
    public partial class Form1 : Form
    {
        // In-memory list to store account details
        public static List<UserAccount> userAccounts = new List<UserAccount>();

        public Form1()
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
            string email = textBox3.Text;
            string username = textBox2.Text;
            string password = textBox1.Text;

            // Check if the username already exists
            foreach (var account in userAccounts)
            {
                if (account.Username == username)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                    return;
                }
            }

            // Create a new user account and add it to the list
            UserAccount newUser = new UserAccount
            {
                Email = email,
                Username = username,
                Password = password
            };
            userAccounts.Add(newUser);

            MessageBox.Show("Account created successfully!");

            // Navigate to the Login page
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
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

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    // UserAccount class to store account details
    public class UserAccount
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
