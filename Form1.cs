using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtnamee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtagee_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string name;
            int age;

            if (string.IsNullOrEmpty(txtnamee.Text) || string.IsNullOrEmpty(txtagee.Text))
            {
                MessageBox.Show("Please enter valid data in all fields");
            }
            else
            {
                name = txtnamee.Text;
                age = int.Parse(txtagee.Text);
                MessageBox.Show("Name: " + name + "\n" + "Age: " + age.ToString());
            }
        }
    }
}
