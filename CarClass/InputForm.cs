using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarClass
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        public Car car;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string make = textBox1.Text;
            int year;

            if(!string.IsNullOrEmpty(make) && int.TryParse(maskedTextBox1.Text, out year))
            {
                car = new Car(make, year);
                this.Close();
            } else
            {
                MessageBox.Show("Please enter valid input", "Invalid input");
            }
        }
    }
}
