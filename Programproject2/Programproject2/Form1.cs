using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programproject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city;
            if (cityListBox.SelectedIndex != -1)
            {
                city = cityListBox.SelectedItem.ToString();
                switch (city)
                {
                    case "Honolulu":
                        timeZoneLabel.Text = "Hawaii-Aleutian UTC-10 hours";
                        break;
                    case "New York":
                        timeZoneLabel.Text = "Eastern UTC-5 hours";
                        break;
                    case "San Francisco":
                        timeZoneLabel.Text = "Pacific UTC-8 hours";
                        break;
                }

            }
            else
            {
                MessageBox.Show("Select a city.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void honoluluRadio_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image =Properties.Resources.Honoseal;
            pictureBox1.Refresh();
            pictureBox1.Visible = true;

        }

        private void newyorkRadio_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.nyseal;
            pictureBox1.Refresh();
            pictureBox1.Visible = true;
        }

        private void sanfranRadio_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.sfseal;
            pictureBox1.Refresh();
            pictureBox1.Visible = true;
        }

        private void creatorCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            creatorLabel.Visible = creatorCheckbox.Checked;
        }

        private void creatorLabel_Click(object sender, EventArgs e)
        {
    
        }

        private void dateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dateLabel.Visible = dateCheckbox.Checked;
        }
    }
}
