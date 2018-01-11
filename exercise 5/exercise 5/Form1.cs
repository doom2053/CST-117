using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualLbl.Text = Math.PI.ToString();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            // Calculate Pi.
               
                

                double pi_over_4 = 0;
                int num_terms = int.Parse(enterBox.Text);
                double sign = 1;
                for (int term = 0; term < num_terms; term++)
                {
                    Console.WriteLine(sign + " / " + (term * 2 + 1) + " = " + (1.0 / (term * 2 + 1)));
                    pi_over_4 += sign / (term * 2 + 1);
                    sign *= -1;
                }

                // Display the result.
                double pi = 4 * pi_over_4;
            piLabel.Text = pi.ToString();
            termLbl.Text = enterBox.Text;

            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void actualLbl_Click(object sender, EventArgs e)
        {

        }
    }
    }

