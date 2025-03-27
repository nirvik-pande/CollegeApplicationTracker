using System;
using System.Drawing;
using System.Windows.Forms;

namespace CollegeApplicationTracker
{
    public partial class AddNewApplication : Form
    {
        public AddNewApplication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox5.Text;
            string location = textBox1.Text;
            string platform = textBox2.Text;
            string dueDate = textBox3.Text;
            string status = checkedListBox1.CheckedItems.Count > 0 ? checkedListBox1.CheckedItems[0].ToString() : string.Empty;
            string type = checkedListBox2.CheckedItems.Count > 0 ? checkedListBox2.CheckedItems[0].ToString() : string.Empty;
            Image image = pictureBox1.Image;

            Application newApplication = new Application
            {
                Name = name,
                Location = location,
                Platform = platform,
                DueDate = dueDate,
                Status = status,
                Type = type,
            
            };

            ApplicationData.Applications.Add(newApplication);

            MessageBox.Show("Application added successfully!");

            // Navigate to the Application Dashboard
            Form2 applicationDashboard = new Form2();
            applicationDashboard.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Navigate back to the Application Dashboard
            Form2 applicationDashboard = new Form2();
            applicationDashboard.Show();
            this.Hide();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the event when the selected index of checkedListBox2 changes
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Handle the event when label3 is clicked
        }
    }
}
