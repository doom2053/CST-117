﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BirdWatcher
{
    public partial class Form1 : Form
    {

        private List<BirdData> birds;
        BirdData currentBird;
        string currentFilePath;
        int currentPosition;
        bool dirtyForm;
        public Form1()
        {
            InitializeComponent();
            birds = new List<BirdData>();
            currentBird = new BirdData();

            dtpDate.Value = DateTime.Now;

            currentPosition = 0;
            dirtyForm = false;
        }



        private void tsbExit_Click(object sender, EventArgs e)
        {

            exitToolStripMenuItem_Click(this, new EventArgs());
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dirtyForm == true)
            {
                if (MessageBox.Show(this, "You have not saved the current bird data; " +
                                 "would you like to save before exiting?", "Save Current Data", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(this, new EventArgs());
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }
        public void ClearForm()
        {
            dirtyForm = true;

            txtBirdName.Text = string.Empty;
            txtHabitat.Text = string.Empty;
            txtBehavior.Text = string.Empty;



            dtpDate.Value = DateTime.Now;


            picBird.Image = null;
        }

        private void btnSetImage_Click(object sender, EventArgs e)
        {
            dirtyForm = true;

            string imageFilePath = string.Empty;

            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Title = "Open Image File";
            OpenFileDialog1.Filter = "JPEG Documents (*.jpg)|*.jpg|Gif Files|*.gif";

            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            imageFilePath = OpenFileDialog1.FileName;
            if (String.IsNullOrEmpty(imageFilePath))
            {
                return;
            }

            if (System.IO.File.Exists(imageFilePath) == false)
            {
                return;
            }

            byte[] bArrImage = new byte[0];
            try
            {
                // convert Image to byte array and save in
                System.IO.FileStream fsImage = null;
                fsImage = System.IO.File.Open(imageFilePath, FileMode.Open, FileAccess.Read);
                bArrImage = new byte[fsImage.Length];
                fsImage.Read(bArrImage, 0, (int)fsImage.Length);
                fsImage.Close();

                currentBird.Picture = bArrImage;
                currentBird.PictureName = imageFilePath;

                MemoryStream ms = new MemoryStream(bArrImage);
                picBird.Image = Image.FromStream(ms);
                ms.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Storing Image");
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dirtyForm == true)
            {
                if (MessageBox.Show(this, "You have not saved the current bird data; " +
                                 "would you like to save before starting a new " +
                                 "bird database?", "Save Current Data", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(this, new EventArgs());
                }
                else
                {
                    // discard and start new document
                    birds = new List<BirdData>();
                    ClearForm();
                }
            }
            else
            {
                // start new document
                birds = new List<BirdData>();
                ClearForm();
            }
        }
        private void openStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dirtyForm == true)
            {
                if (MessageBox.Show(this, "You have not saved the current bird data; " +
                                 "would you like to save before opening a different " +
                                 "bird database?", "Save Current Data", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(this, new EventArgs());
                }
                else
                {
                    Open();
                }
            }
            else
            {
                Open();
            }
        }
        public void Open()
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Title = "Open BRD Document";
            OpenFileDialog1.Filter = "BRD Documents (*.brd)|*.brd";
            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            currentFilePath = OpenFileDialog1.FileName;
            if (String.IsNullOrEmpty(currentFilePath))
            {
                return;
            }

            if (System.IO.File.Exists(currentFilePath) == false)
            {
                return;
            }

            birds = FileSerializer.Deserialize(currentFilePath);

            // Load bird at position zero
            if (birds != null)
            {
                currentBird = birds.ElementAt<BirdWatcher.BirdData>(0);
                LoadCurrentBird();
                dirtyForm = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCurrentBird();

            if (String.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

                try
                {
                    SaveFileDialog1.Title = "Save BRD Document";
                    SaveFileDialog1.Filter = "BRD Documents (*.brd)|*.brd";

                    if (SaveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    {
                        return;
                    }
                }
                catch
                {
                    return;
                }

                currentFilePath = SaveFileDialog1.FileName;
                if (String.IsNullOrEmpty(currentFilePath))
                {
                    return;
                }
            }
            FileSerializer.Serialize(currentFilePath, birds);

            MessageBox.Show("File " + currentFilePath + " saved.", "File Saved.");

            dirtyForm = false;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

            try
            {
                SaveFileDialog1.Title = "Save BRD Document";
                SaveFileDialog1.Filter = "BRD Documents (*.brd)|*.brd";

                if (SaveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
            }
            catch
            {
                return;
            }

            currentFilePath = SaveFileDialog1.FileName;

            if (String.IsNullOrEmpty(currentFilePath))
            {
                return;
            }

            FileSerializer.Serialize(currentFilePath, birds);

            MessageBox.Show("File " + currentFilePath + " saved.", "File Saved.");

            dirtyForm = false;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(this, new EventArgs());
        }
        private void SaveCurrentBird()
        {
            if (!String.IsNullOrEmpty(txtBirdName.Text))
            {
                try
                {
                    currentBird.BirdName = txtBirdName.Text;
                    currentBird.Habitat = txtHabitat.Text;
                    currentBird.BehaviorObserved = txtBehavior.Text;

                   

                    currentBird.DateViewed = dtpDate.Value;
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            SaveCurrentBird();
            currentBird = new BirdData();
            ClearForm();
            birds.Add(currentBird);
            dirtyForm = true;
        }

        private void tsbRemoveBird_Click(object sender, EventArgs e)
        {
            birds.RemoveAt(currentPosition);

            if (currentPosition == 0)
                currentPosition++;
            else
                currentPosition--;

            currentBird = birds[currentPosition];
            LoadCurrentBird();
            dirtyForm = true;
        }

        private void tsbFindBird_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(birds);
            f.BirdNameUpdated += new Form3.BirdNameUpdateHandler(FindBird);
            f.Show();
        }
        private void FindBird(object sender, BirdNameUpdateEventArgs e)
        {
            for (int i = 0; i < birds.Count; i++)
            {
                if (birds[i].BirdName == e.BirdName)
                {
                    currentBird = birds[i];
                    LoadCurrentBird();
                    currentPosition = i;
                }
            }
        }

        private void listAllBirdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(birds);
            f.Show();
        }
        private void LoadCurrentBird()
        {
            try
            {
                txtBirdName.Text = currentBird.BirdName;
                txtHabitat.Text = currentBird.Habitat;
                txtBehavior.Text = currentBird.BehaviorObserved;
            }
            catch { }

            try
            {
                dtpDate.Value = currentBird.DateViewed;
            }
            catch { }

            try
            {

                if (currentBird.Picture != null)
                {
                    MemoryStream ms = new MemoryStream(currentBird.Picture);
                    picBird.Image = Image.FromStream(ms);
                    ms.Dispose();
                }
                else
                {
                    picBird.Image = null;
                }
            }
            catch
            {
                picBird.Image = null;
            }
        }

        private void tsbNavBack_Click(object sender, EventArgs e)
        {
            SaveCurrentBird();

            if (currentPosition != 0)
            {
                currentPosition--;
                currentBird = birds[currentPosition];
                LoadCurrentBird();
            }
        }

        private void tsbNavForward_Click(object sender, EventArgs e)
        {

            SaveCurrentBird();

            if (currentPosition < birds.Count - 1)
            {
                currentPosition++;
                currentBird = birds[currentPosition];
                LoadCurrentBird();
            }
        }
        private void txtBirdName_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirtyForm = true;
        }
       
        private void txtLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirtyForm = true;
        }
        private void txtBehavior_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirtyForm = true;
        }
        private void dtpDate_CloseUp(object sender, EventArgs e)
        {
            dirtyForm = true;
        }

      
    }
        }
    


