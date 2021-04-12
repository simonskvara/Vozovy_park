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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            this.Hide();
            form1.Show();
        }

        private void buttonAddCars_Click(object sender, EventArgs e)
        {
            addCars form = new addCars();
            this.Hide();
            form.Show();
        }

        private void buttonAddCustom_Click(object sender, EventArgs e)
        {
            addCustomers form = new addCustomers();
            this.Hide();
            form.Show();
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            rentCar form = new rentCar();
            this.Hide();
            form.Show();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            returnCar form = new returnCar();
            this.Hide();
            form.Show();
        }
    }
}
