using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void convertbutton_Click(object sender, EventArgs e)
        {
            double C;
            double F;

            F = double.Parse(TemperatureBox.Text);
            C = 5.0 / 9.0 * (F - 32);
            celsiusBox.Text = C.ToString();
        }
    }
}
