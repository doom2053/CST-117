namespace Programproject2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cityListBox = new System.Windows.Forms.ListBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.timeZoneLabel = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.honoluluRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newyorkRadio = new System.Windows.Forms.RadioButton();
            this.sanfranRadio = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.creatorCheckbox = new System.Windows.Forms.CheckBox();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.dateCheckbox = new System.Windows.Forms.CheckBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a city and I will give you the time zone.";
            // 
            // cityListBox
            // 
            this.cityListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityListBox.FormattingEnabled = true;
            this.cityListBox.ItemHeight = 20;
            this.cityListBox.Items.AddRange(new object[] {
            "Honolulu",
            "New York",
            "San Francisco"});
            this.cityListBox.Location = new System.Drawing.Point(58, 102);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(148, 64);
            this.cityListBox.TabIndex = 1;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(12, 189);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(88, 20);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Time Zone:";
            // 
            // timeZoneLabel
            // 
            this.timeZoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeZoneLabel.Location = new System.Drawing.Point(106, 189);
            this.timeZoneLabel.Name = "timeZoneLabel";
            this.timeZoneLabel.Size = new System.Drawing.Size(141, 44);
            this.timeZoneLabel.TabIndex = 3;
            this.timeZoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v
            // 
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v.Location = new System.Drawing.Point(12, 411);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(138, 62);
            this.v.TabIndex = 4;
            this.v.Text = "OK";
            this.v.UseVisualStyleBackColor = true;
            this.v.Click += new System.EventHandler(this.okButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(361, 411);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(138, 62);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // honoluluRadio
            // 
            this.honoluluRadio.AutoSize = true;
            this.honoluluRadio.Location = new System.Drawing.Point(6, 24);
            this.honoluluRadio.Name = "honoluluRadio";
            this.honoluluRadio.Size = new System.Drawing.Size(91, 17);
            this.honoluluRadio.TabIndex = 6;
            this.honoluluRadio.TabStop = true;
            this.honoluluRadio.Text = "Honolulu Seal";
            this.honoluluRadio.UseVisualStyleBackColor = true;
            this.honoluluRadio.CheckedChanged += new System.EventHandler(this.honoluluRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newyorkRadio);
            this.groupBox1.Controls.Add(this.sanfranRadio);
            this.groupBox1.Controls.Add(this.honoluluRadio);
            this.groupBox1.Location = new System.Drawing.Point(288, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seals";
            // 
            // newyorkRadio
            // 
            this.newyorkRadio.AutoSize = true;
            this.newyorkRadio.Location = new System.Drawing.Point(6, 47);
            this.newyorkRadio.Name = "newyorkRadio";
            this.newyorkRadio.Size = new System.Drawing.Size(96, 17);
            this.newyorkRadio.TabIndex = 8;
            this.newyorkRadio.TabStop = true;
            this.newyorkRadio.Text = "New York Seal";
            this.newyorkRadio.UseVisualStyleBackColor = true;
            this.newyorkRadio.CheckedChanged += new System.EventHandler(this.newyorkRadio_CheckedChanged);
            // 
            // sanfranRadio
            // 
            this.sanfranRadio.AutoSize = true;
            this.sanfranRadio.Location = new System.Drawing.Point(6, 77);
            this.sanfranRadio.Name = "sanfranRadio";
            this.sanfranRadio.Size = new System.Drawing.Size(117, 17);
            this.sanfranRadio.TabIndex = 7;
            this.sanfranRadio.TabStop = true;
            this.sanfranRadio.Text = "San Francisco Seal";
            this.sanfranRadio.UseVisualStyleBackColor = true;
            this.sanfranRadio.CheckedChanged += new System.EventHandler(this.sanfranRadio_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(285, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // creatorCheckbox
            // 
            this.creatorCheckbox.AutoSize = true;
            this.creatorCheckbox.Location = new System.Drawing.Point(20, 272);
            this.creatorCheckbox.Name = "creatorCheckbox";
            this.creatorCheckbox.Size = new System.Drawing.Size(94, 17);
            this.creatorCheckbox.TabIndex = 9;
            this.creatorCheckbox.Text = "Creator Name:";
            this.creatorCheckbox.UseVisualStyleBackColor = true;
            this.creatorCheckbox.CheckedChanged += new System.EventHandler(this.creatorCheckbox_CheckStateChanged);
            // 
            // creatorLabel
            // 
            this.creatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creatorLabel.Location = new System.Drawing.Point(120, 268);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(99, 23);
            this.creatorLabel.TabIndex = 10;
            this.creatorLabel.Text = "Mark Piland";
            this.creatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.creatorLabel.Visible = false;
            this.creatorLabel.Click += new System.EventHandler(this.creatorLabel_Click);
            // 
            // dateCheckbox
            // 
            this.dateCheckbox.AutoSize = true;
            this.dateCheckbox.Location = new System.Drawing.Point(20, 318);
            this.dateCheckbox.Name = "dateCheckbox";
            this.dateCheckbox.Size = new System.Drawing.Size(52, 17);
            this.dateCheckbox.TabIndex = 11;
            this.dateCheckbox.Text = "Date:";
            this.dateCheckbox.UseVisualStyleBackColor = true;
            this.dateCheckbox.CheckedChanged += new System.EventHandler(this.dateCheckbox_CheckedChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLabel.Location = new System.Drawing.Point(107, 314);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(112, 23);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "12/24/17";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 485);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateCheckbox);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.creatorCheckbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.v);
            this.Controls.Add(this.timeZoneLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.cityListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox cityListBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label timeZoneLabel;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton honoluluRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton newyorkRadio;
        private System.Windows.Forms.RadioButton sanfranRadio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox creatorCheckbox;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.CheckBox dateCheckbox;
        private System.Windows.Forms.Label dateLabel;
    }
}

