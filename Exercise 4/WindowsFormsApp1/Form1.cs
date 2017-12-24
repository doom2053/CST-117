using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Calculatebtn_Click(object sender, EventArgs e)
        {

            //Declaring Variables
            int totalSeconds;
            int hours;
            int minutes;
            int days;
            int minutesRemainder;
            int hoursRemainderMinutes;
            int hoursRemainderSeconds;

            // Parsing and calculations

            totalSeconds = int.Parse(textconvert.Text);
            minutes = totalSeconds / 60;
            minutesRemainder = totalSeconds % 60;
            hours = minutes / 60;
            hoursRemainderMinutes = minutes % 60;
            hoursRemainderSeconds = hoursRemainderMinutes % 60;
            days = hours / 24;

            if (totalSeconds >= 86400)
            {
                MessageBox.Show(days.ToString() + " day(s)");
            }
            else if (totalSeconds >= 3600)
            {
                MessageBox.Show(hours.ToString() + " hour(s) " );
            }
            else if (totalSeconds >= 60)
            {
                MessageBox.Show(minutes.ToString() + " minute(s) " );
            }
            else
            {
                MessageBox.Show(totalSeconds.ToString());
            }
        }
    }
}
