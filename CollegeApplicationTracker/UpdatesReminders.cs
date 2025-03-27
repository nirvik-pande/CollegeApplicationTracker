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
    public partial class UpdatesReminders : Form
    {
        public UpdatesReminders()
        {
            InitializeComponent();
        }

        private void UpdatesReminders_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 applicationDashboard = new Form2();
            applicationDashboard.Show();
            this.Hide();
        }
    }
}
