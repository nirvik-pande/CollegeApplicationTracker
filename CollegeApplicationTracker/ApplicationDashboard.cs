using System;
using System.Configuration;
using System.Drawing;
using System.Linq;
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

        private void LoadApplications(string name = "", string type = "", string status = "")
        {
            listBox1.Items.Clear();
            var filteredApps = ApplicationData.Applications.Where(app =>
                (string.IsNullOrEmpty(name) || app.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrEmpty(type) || app.Type == type) &&
                (string.IsNullOrEmpty(status) || app.Status == status)
            );

            foreach (var app in filteredApps)
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
            e.Graphics.DrawString(app.Name, e.Font, Brushes.Black, e.Bounds.Left + 60, e.Bounds.Top);
            e.Graphics.DrawString(app.Location, e.Font, Brushes.Gray, e.Bounds.Left + 60, e.Bounds.Top + 20);
            e.Graphics.DrawString(app.Platform, e.Font, Brushes.Gray, e.Bounds.Left + 60, e.Bounds.Top + 40);
            e.Graphics.DrawString(app.DueDate, e.Font, Brushes.Gray, e.Bounds.Left + 60, e.Bounds.Top + 60);
            e.Graphics.DrawString(app.Status, e.Font, Brushes.Gray, e.Bounds.Left + 60, e.Bounds.Top + 80);
            e.Graphics.DrawString(app.Type, e.Font, Brushes.Gray, e.Bounds.Left + 60, e.Bounds.Top + 100); 
            e.DrawFocusRectangle();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Application selectedApp = (Application)listBox1.SelectedItem;
                UpdateApplication updateApplicationPage = new UpdateApplication(selectedApp);
                updateApplicationPage.Show();
                this.Hide();
            }
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
            // Navigate to the Settings page
            /*
            SettingsPage settingsPage = new SettingsPage();
            settingsPage.Show();
            this.Hide();
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Navigate to the Add New Application page
            AddNewApplication addNewApplicationPage = new AddNewApplication();
            addNewApplicationPage.Show();
            this.Hide();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the event when the selected index of checkedListBox2 changes
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Handle the event when label3 is clicked
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Handle the event when Form2 is loaded
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string type = checkedListBox1.CheckedItems.Count > 0 ? checkedListBox1.CheckedItems[0].ToString() : string.Empty;
            string status = checkedListBox2.CheckedItems.Count > 0 ? checkedListBox2.CheckedItems[0].ToString() : string.Empty;

            LoadApplications(name, type, status);
        }
    }
}
