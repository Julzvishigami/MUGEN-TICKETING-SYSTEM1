using MUGENTICKETSYSTEM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUGEN_SYSTEM
{
        public partial class AdminDashboard : Form
        {
            private string username;

            public AdminDashboard(string user)
            {
                InitializeComponent();
                username = user;
            }
        

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Ask user for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Hide the current dashboard window
                this.Hide();

                // Show login form again
                LogInForm login = new LogInForm();
                login.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 n = new Form5();
            n.Show();
            this.Hide();
        }

        private void TrainBtn_Click(object sender, EventArgs e)
        {
            Form6 t = new Form6();
            t.Show();
            this.Hide();
        }

        private void SchedBtn_Click(object sender, EventArgs e)
        {
            Form7 s = new Form7();
            s.Show();
            this.Hide();
        }

        private void FaresBtn_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
            this.Hide();
        }

        private void AccBtn_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            a.Show();
            this.Hide();
        }
    }
}
