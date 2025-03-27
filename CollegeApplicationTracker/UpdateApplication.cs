using System;
using System.Windows.Forms;

namespace CollegeApplicationTracker
{
    public partial class UpdateApplication : Form
    {
        private Application _application;

        public UpdateApplication(Application application)
        {
            InitializeComponent();
            _application = application;
            LoadApplicationData();
        }

        private void LoadApplicationData()
        {
            textBox5.Text = _application.Name;
            textBox1.Text = _application.Location;
            textBox2.Text = _application.Platform;
            textBox3.Text = _application.DueDate;
            textBox4.Text = _application.Ranking; // Assuming textBox4 is for Ranking
            checkedListBox1.SetItemChecked(checkedListBox1.Items.IndexOf(_application.Status), true);
            checkedListBox2.SetItemChecked(checkedListBox2.Items.IndexOf(_application.Type), true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _application.Name = textBox5.Text;
            _application.Location = textBox1.Text;
            _application.Platform = textBox2.Text;
            _application.DueDate = textBox3.Text;
            _application.Ranking = textBox4.Text; // Ensure ranking is saved
            _application.Status = checkedListBox1.CheckedItems.Count > 0 ? checkedListBox1.CheckedItems[0].ToString() : string.Empty;
            _application.Type = checkedListBox2.CheckedItems.Count > 0 ? checkedListBox2.CheckedItems[0].ToString() : string.Empty;

            MessageBox.Show("Application updated successfully!");

            // Navigate back to the Application Dashboard
            Form2 applicationDashboard = new Form2();
            applicationDashboard.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Navigate back to the Application Dashboard without saving
            Form2 applicationDashboard = new Form2();
            applicationDashboard.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void UpdateApplication_Load(object sender, EventArgs e) { }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
