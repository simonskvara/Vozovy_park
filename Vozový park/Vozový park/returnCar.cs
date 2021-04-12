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
    public partial class returnCar : Form
    {
        public returnCar()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.Show();
        }

        private void returnCar_Load(object sender, EventArgs e)
        {

        }
    }
}
