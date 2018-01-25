using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise8final
{
    public partial class Exercise8 : Form
    {
        public Exercise8()
        {
            InitializeComponent();
        }
        private double fatCalories(double fatGrams)
        {
            return fatGrams * 9;
        }
        private double carbsCalories(double carbsGrams)
        {
            return carbsGrams * 4;
        }
        

        

        private void clearBtn_Click(object sender, EventArgs e)
        {
            
                fatTextbox.Text = "";
                carbsTextbox.Text = "";
                calfatLbl.Text = "";
                calCarbsLbl.Text = "";
                fatTextbox.Focus();
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            double calFromFat, fatGrams, calFromCarbs, carbsGrams;
            if (double.TryParse(fatTextbox.Text, out fatGrams))
            {
                calFromFat = fatGrams * 9;
                calfatLbl.Text = calFromFat.ToString("n1");
            }
            else
            {
                MessageBox.Show("Enter a valid number for Fat Grams.");
            }
            if (double.TryParse(carbsTextbox.Text, out carbsGrams))
            {
                calFromCarbs = carbsGrams * 4;

                calCarbsLbl.Text = calFromCarbs.ToString("n1");
            }
            else
            {
                MessageBox.Show("Enter a valid number for Carbs Grams.");
            }
        }
    }
}
