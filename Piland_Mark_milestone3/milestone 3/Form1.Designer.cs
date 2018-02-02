namespace BirdWatcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbxImage = new System.Windows.Forms.GroupBox();
            this.btnSetImage = new System.Windows.Forms.Button();
            this.picBird = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtBehavior = new System.Windows.Forms.TextBox();
            this.lblBehavior = new System.Windows.Forms.Label();
            this.txtHabitat = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtBirdName = new System.Windows.Forms.TextBox();
            this.lblBirdName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllBirdsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveBird = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFindBird = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNavBack = new System.Windows.Forms.ToolStripButton();
            this.tsbNavForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.gbxImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxImage
            // 
            this.gbxImage.Controls.Add(this.btnSetImage);
            this.gbxImage.Controls.Add(this.picBird);
            this.gbxImage.Location = new System.Drawing.Point(429, 62);
            this.gbxImage.Name = "gbxImage";
            this.gbxImage.Size = new System.Drawing.Size(219, 225);
            this.gbxImage.TabIndex = 28;
            this.gbxImage.TabStop = false;
            this.gbxImage.Text = "Image";
            // 
            // btnSetImage
            // 
            this.btnSetImage.Location = new System.Drawing.Point(72, 196);
            this.btnSetImage.Name = "btnSetImage";
            this.btnSetImage.Size = new System.Drawing.Size(75, 23);
            this.btnSetImage.TabIndex = 0;
            this.btnSetImage.Text = "Set Image";
            this.btnSetImage.UseVisualStyleBackColor = true;
            this.btnSetImage.Click += new System.EventHandler(this.btnSetImage_Click);
            // 
            // picBird
            // 
            this.picBird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBird.Location = new System.Drawing.Point(6, 19);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(206, 171);
            this.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBird.TabIndex = 0;
            this.picBird.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(77, 279);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(93, 20);
            this.dtpDate.TabIndex = 22;
            // 
            // txtBehavior
            // 
            this.txtBehavior.Location = new System.Drawing.Point(77, 198);
            this.txtBehavior.MaxLength = 500;
            this.txtBehavior.Multiline = true;
            this.txtBehavior.Name = "txtBehavior";
            this.txtBehavior.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBehavior.Size = new System.Drawing.Size(315, 66);
            this.txtBehavior.TabIndex = 20;
            // 
            // lblBehavior
            // 
            this.lblBehavior.AutoSize = true;
            this.lblBehavior.Location = new System.Drawing.Point(12, 198);
            this.lblBehavior.Name = "lblBehavior";
            this.lblBehavior.Size = new System.Drawing.Size(52, 13);
            this.lblBehavior.TabIndex = 25;
            this.lblBehavior.Text = "Behavior:";
            // 
            // txtHabitat
            // 
            this.txtHabitat.Location = new System.Drawing.Point(77, 105);
            this.txtHabitat.MaxLength = 500;
            this.txtHabitat.Multiline = true;
            this.txtHabitat.Name = "txtHabitat";
            this.txtHabitat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHabitat.Size = new System.Drawing.Size(315, 64);
            this.txtHabitat.TabIndex = 19;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 108);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(44, 13);
            this.lblLocation.TabIndex = 24;
            this.lblLocation.Text = "Habitat:";
            // 
            // txtBirdName
            // 
            this.txtBirdName.Location = new System.Drawing.Point(77, 62);
            this.txtBirdName.MaxLength = 100;
            this.txtBirdName.Name = "txtBirdName";
            this.txtBirdName.Size = new System.Drawing.Size(315, 20);
            this.txtBirdName.TabIndex = 15;
            // 
            // lblBirdName
            // 
            this.lblBirdName.AutoSize = true;
            this.lblBirdName.Location = new System.Drawing.Point(9, 65);
            this.lblBirdName.Name = "lblBirdName";
            this.lblBirdName.Size = new System.Drawing.Size(59, 13);
            this.lblBirdName.TabIndex = 18;
            this.lblBirdName.Text = "Bird Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openStripMenuItem2,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openStripMenuItem2
            // 
            this.openStripMenuItem2.Name = "openStripMenuItem2";
            this.openStripMenuItem2.Size = new System.Drawing.Size(123, 22);
            this.openStripMenuItem2.Text = "&Open";
            this.openStripMenuItem2.Click += new System.EventHandler(this.openStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "&Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllBirdsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // listAllBirdsToolStripMenuItem
            // 
            this.listAllBirdsToolStripMenuItem.Name = "listAllBirdsToolStripMenuItem";
            this.listAllBirdsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listAllBirdsToolStripMenuItem.Text = "&List All Birds...";
            this.listAllBirdsToolStripMenuItem.Click += new System.EventHandler(this.listAllBirdsToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbRemoveBird,
            this.toolStripSeparator2,
            this.tsbFindBird,
            this.toolStripSeparator5,
            this.tsbSave,
            this.toolStripSeparator4,
            this.tsbNavBack,
            this.tsbNavForward,
            this.toolStripSeparator3,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(671, 25);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "Add Bird";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbRemoveBird
            // 
            this.tsbRemoveBird.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveBird.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveBird.Image")));
            this.tsbRemoveBird.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveBird.Name = "tsbRemoveBird";
            this.tsbRemoveBird.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveBird.Text = "Delete Current Bird";
            this.tsbRemoveBird.Click += new System.EventHandler(this.tsbRemoveBird_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFindBird
            // 
            this.tsbFindBird.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFindBird.Image = ((System.Drawing.Image)(resources.GetObject("tsbFindBird.Image")));
            this.tsbFindBird.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFindBird.Name = "tsbFindBird";
            this.tsbFindBird.Size = new System.Drawing.Size(23, 22);
            this.tsbFindBird.Text = "Find Bird By Name";
            this.tsbFindBird.Click += new System.EventHandler(this.tsbFindBird_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Save Current Data";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbNavBack
            // 
            this.tsbNavBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNavBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbNavBack.Image")));
            this.tsbNavBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNavBack.Name = "tsbNavBack";
            this.tsbNavBack.Size = new System.Drawing.Size(23, 22);
            this.tsbNavBack.Text = "Navigate Back to Previous Bird";
            this.tsbNavBack.Click += new System.EventHandler(this.tsbNavBack_Click);
            // 
            // tsbNavForward
            // 
            this.tsbNavForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNavForward.Image = ((System.Drawing.Image)(resources.GetObject("tsbNavForward.Image")));
            this.tsbNavForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNavForward.Name = "tsbNavForward";
            this.tsbNavForward.Size = new System.Drawing.Size(23, 22);
            this.tsbNavForward.Text = "Navigate Forward to Next Bird";
            this.tsbNavForward.Click += new System.EventHandler(this.tsbNavForward_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(23, 22);
            this.tsbExit.Text = "Exit";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 320);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbxImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtBehavior);
            this.Controls.Add(this.lblBehavior);
            this.Controls.Add(this.txtHabitat);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtBirdName);
            this.Controls.Add(this.lblBirdName);
            this.Name = "Form1";
            this.Text = "Bird Viewer";
            this.gbxImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxImage;
        private System.Windows.Forms.Button btnSetImage;
        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtBehavior;
        private System.Windows.Forms.Label lblBehavior;
        private System.Windows.Forms.TextBox txtHabitat;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtBirdName;
        private System.Windows.Forms.Label lblBirdName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllBirdsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbRemoveBird;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbFindBird;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbNavBack;
        private System.Windows.Forms.ToolStripButton tsbNavForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbExit;
    }
}

