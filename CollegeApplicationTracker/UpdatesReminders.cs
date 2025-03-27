using System;
using System.Linq;
using System.Windows.Forms;
using System.Timers;

namespace CollegeApplicationTracker
{
    public partial class UpdatesReminders : Form
    {
        private System.Timers.Timer timer;

        public UpdatesReminders()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer(60000); // Check every minute
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            CheckReminders();
        }

        private void CheckReminders()
        {
            var now = DateTime.Now;
            foreach (var reminder in ReminderData.Reminders)
            {
                if (reminder.Date.Date == now.Date && reminder.Time.Hour == now.Hour && reminder.Time.Minute == now.Minute)
                {
                    ShowReminderPopup(reminder);
                }
            }
        }

        private void ShowReminderPopup(Reminder reminder)
        {
            MessageBox.Show($"Reminder: {reminder.Name}", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox5.Text;
            DateTime date;
            DateTime time;

            if (string.IsNullOrEmpty(name) || !DateTime.TryParse(textBox1.Text, out date) || !DateTime.TryParse(textBox2.Text, out time))
            {
                MessageBox.Show("Please enter valid reminder details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var reminder = new Reminder
            {
                Name = name,
                Date = date,
                Time = time
            };

            ReminderData.Reminders.Add(reminder);
            listBox1.Items.Add(reminder);

            MessageBox.Show("Reminder added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 applicationDashboard = new Form2();
            applicationDashboard.Show();
            this.Hide();
        }

        private void UpdatesReminders_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var reminder in ReminderData.Reminders)
            {
                listBox1.Items.Add(reminder);
            }
        }
    }
}
