using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vozový_park
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string uName = txtUname.Text;
            string password = txtPass.Text;

            if (uName.Equals("admin") && password.Equals("admin"))
            {
                MessageBox.Show("Logged in");
                Main m = new Main();
                this.Hide();
                m.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
                txtUname.Clear();
                txtPass.Clear();
                txtUname.Focus();
            }


        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
