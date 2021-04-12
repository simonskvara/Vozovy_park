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
    public partial class addCars : Form
    {
        public addCars()
        {
            InitializeComponent();
        }

        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string carNum = txtCarNum.Text;
            string make = txtMake.Text;
            string model = txtModel.Text;
            //string available = txtAvail.SelectedItem.ToString();

            string carInfo = carNum + ", " + make + ", " + model;
            listBoxCars.Items.Add(carInfo);

            txtCarNum.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtCarNum.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.Show();

            string[] arr = new string[listBoxCars.Items.Count];
            for (int i = 0; i < listBoxCars.Items.Count; i++)
            {
                arr[i] = listBoxCars.Items[i].ToString();
            }

            File.WriteAllLines("cars.txt", arr);
        }

        private void addCars_Load(object sender, EventArgs e)
        {
            try
            {
                string[] cars = File.ReadAllLines("cars.txt");
                foreach (var item in cars)
                {
                    listBoxCars.Items.Add(item);
                }
            }
            catch (FileNotFoundException)
            {

            }
        }
    }
}
