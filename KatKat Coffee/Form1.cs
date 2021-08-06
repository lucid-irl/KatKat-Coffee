using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatKat_Coffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Guest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dashboard ds = new dashboard("Guest");
            ds.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                dashboard ds = new dashboard("Admin");
                ds.Show();
                this.Hide();
            }
            else
            {
                dashboard dss = new dashboard("Staff");
                dss.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
