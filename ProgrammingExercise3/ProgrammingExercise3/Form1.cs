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
namespace ProgrammingExercise3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void fileBtn_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileBox.Text = ofd.FileName;

                textBox1.Text = File.ReadAllText(fileBox.Text);
                textBox1.CharacterCasing = CharacterCasing.Lower;
                textBox1.ScrollBars = ScrollBars.Both;
                textBox1.WordWrap = false;

            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "unkonwn.txt";
            saveFileDialog1.Filter = "Text File|*.txt|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text + Environment.NewLine + longestBox.Text + Environment.NewLine + vowelBox.Text + Environment.NewLine + firstBox.Text);



            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void longestBtn_Click(object sender, EventArgs e)
        {

            string line = textBox1.Text;
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            longestBox.Text = ("Longest word is: " + word);


        }


        private void longestBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vowelsBtn_Click(object sender, EventArgs e)
        {

            string ctr = textBox1.Text;

            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            var result = ctr.ToCharArray().Where(c => vowels.Contains(c));


            vowelBox.Text = ("Word with the most vowel is: " + result.Count());

        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            string ctr = textBox1.Text;
            string myfirstWord = ctr.Split(' ').First();
            string myLastWord = ctr.Split(' ').Last();
            

            firstBox.Text = ("The first and last words are:" + myfirstWord + " and " + myLastWord);


        }
        }
}
    

        


