using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vozový_park
{
    public partial class rentCar : Form
    {
        public rentCar()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.Show();

            string[] arr = new string[listBoxRent.Items.Count];
            for (int i = 0; i < listBoxRent.Items.Count; i++)
            {
                arr[i] = listBoxRent.Items[i].ToString();
            }

            File.WriteAllLines("rent.txt", arr);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string carID = textBoxID.Text;
            string customID = txtCustomID.Text;
            string customName = txtCustomName.Text;
            string date = datePicker.Text;

            string rentInfo = carID + ", " + customID + ", " + customName + ", " + date;
            listBoxRent.Items.Add(rentInfo);
            textBoxID.Clear();
            txtCustomID.Clear();
            txtCustomName.Clear();
            textBoxID.Focus();
        }

        private void rentCar_Load(object sender, EventArgs e)
        {
            try
            {
                string[] cars = File.ReadAllLines("rent.txt");
                foreach (var item in cars)
                {
                    listBoxRent.Items.Add(item);
                }
            }
            catch (FileNotFoundException)
            {

            }
        }
    }
}
