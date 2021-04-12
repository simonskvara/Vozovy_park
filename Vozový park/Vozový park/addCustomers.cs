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
    public partial class addCustomers : Form
    {
        public addCustomers()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string name = txtName.Text;
            string mobile = txtMobile.Text;

            string customInfo = ID + ", " + name + ", " + mobile;
            listBoxCustom.Items.Add(customInfo);

            txtID.Clear();
            txtName.Clear();
            txtMobile.Clear();
            txtID.Focus();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.Show();

            string[] arr = new string[listBoxCustom.Items.Count];
            for (int i = 0; i < listBoxCustom.Items.Count; i++)
            {
                arr[i] = listBoxCustom.Items[i].ToString();
            }

            File.WriteAllLines("customers.txt", arr);

        }

        private void addCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                string[] cars = File.ReadAllLines("customers.txt");
                foreach (var item in cars)
                {
                    listBoxCustom.Items.Add(item);
                }
            }
            catch (FileNotFoundException)
            {

            }
        }
    }
}
