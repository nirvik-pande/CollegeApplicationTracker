using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace CollegeApplicationTracker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadApplications();
        }

        private void LoadApplications()
        {
            listBox1.Items.Clear();
            foreach (var app in ApplicationData.Applications)
            {
                listBox1.Items.Add(app);
            }
        }

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 100; // Set the height for each item
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            Application app = (Application)listBox1.Items[e.Index];
            e.DrawBackground();
            e.Graphics.DrawImage(app.Image, e.Bounds.Left, e.Bounds.Top, 50, 50);
            e.Graphics.DrawString(app.Name, e.Font, Brushes.Black, e.Bounds.Left + 60, e.Bounds.Top);
            e.Graphics.DrawString(app.Location, e.Font, Brushes.Gray, e.Bounds.Left + 60, e.Bounds.Top + 20);
            e.Graphics.DrawString(app.Platform, e.Font, Brushes.Gray, e.Bounds.Left + 60, e.Bounds.Top + 40);
            e.Graphics.DrawString(app.DueDate, e.Font, Brushes.Gray, e.Bounds.Left + 60, e.Bounds.Top + 60);
            e.Graphics.DrawString(app.Status, e.Font, Brushes.Gray, e.Bounds.Left + 60, e.Bounds.Top + 80);
            e.DrawFocusRectangle();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the event when the selected index of checkedListBox2 changes
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Handle the event when label3 is clicked
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Navigate to the Updates and Reminders page
            UpdatesReminders updatesRemindersPage = new UpdatesReminders();
            updatesRemindersPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Navigate to the Add New Application page
            AddNewApplication addNewApplicationPage = new AddNewApplication();
            addNewApplicationPage.Show();
            this.Hide();
        }
    }
}
