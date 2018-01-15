namespace ProgrammingExercise3
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
            this.fileBtn = new System.Windows.Forms.Button();
            this.fileBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.longestBtn = new System.Windows.Forms.Button();
            this.longestBox = new System.Windows.Forms.TextBox();
            this.vowelsBtn = new System.Windows.Forms.Button();
            this.vowelBox = new System.Windows.Forms.TextBox();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.firstBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileBtn
            // 
            this.fileBtn.Location = new System.Drawing.Point(12, 12);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(91, 23);
            this.fileBtn.TabIndex = 0;
            this.fileBtn.Text = "Open File";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // fileBox
            // 
            this.fileBox.Location = new System.Drawing.Point(110, 14);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(305, 20);
            this.fileBox.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(403, 140);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 48);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(91, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save New File";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // longestBtn
            // 
            this.longestBtn.Location = new System.Drawing.Point(5, 223);
            this.longestBtn.Name = "longestBtn";
            this.longestBtn.Size = new System.Drawing.Size(117, 34);
            this.longestBtn.TabIndex = 5;
            this.longestBtn.Text = "Longest Word";
            this.longestBtn.UseVisualStyleBackColor = true;
            this.longestBtn.Click += new System.EventHandler(this.longestBtn_Click);
            // 
            // longestBox
            // 
            this.longestBox.Location = new System.Drawing.Point(5, 263);
            this.longestBox.Multiline = true;
            this.longestBox.Name = "longestBox";
            this.longestBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.longestBox.Size = new System.Drawing.Size(117, 150);
            this.longestBox.TabIndex = 8;
            this.longestBox.TextChanged += new System.EventHandler(this.longestBox_TextChanged);
            // 
            // vowelsBtn
            // 
            this.vowelsBtn.Location = new System.Drawing.Point(137, 223);
            this.vowelsBtn.Name = "vowelsBtn";
            this.vowelsBtn.Size = new System.Drawing.Size(118, 34);
            this.vowelsBtn.TabIndex = 9;
            this.vowelsBtn.Text = "Most Vowels";
            this.vowelsBtn.UseVisualStyleBackColor = true;
            this.vowelsBtn.Click += new System.EventHandler(this.vowelsBtn_Click);
            // 
            // vowelBox
            // 
            this.vowelBox.Location = new System.Drawing.Point(137, 263);
            this.vowelBox.Multiline = true;
            this.vowelBox.Name = "vowelBox";
            this.vowelBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.vowelBox.Size = new System.Drawing.Size(118, 149);
            this.vowelBox.TabIndex = 10;
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(273, 263);
            this.firstBox.Multiline = true;
            this.firstBox.Name = "firstBox";
            this.firstBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.firstBox.Size = new System.Drawing.Size(132, 150);
            this.firstBox.TabIndex = 12;
            // 
            // firstBtn
            // 
            this.firstBtn.Location = new System.Drawing.Point(261, 223);
            this.firstBtn.Name = "firstBtn";
            this.firstBtn.Size = new System.Drawing.Size(154, 34);
            this.firstBtn.TabIndex = 13;
            this.firstBtn.Text = "First and Last Word Alphabetical";
            this.firstBtn.UseVisualStyleBackColor = true;
            this.firstBtn.Click += new System.EventHandler(this.firstBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 425);
            this.Controls.Add(this.firstBtn);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.vowelBox);
            this.Controls.Add(this.vowelsBtn);
            this.Controls.Add(this.longestBox);
            this.Controls.Add(this.longestBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fileBox);
            this.Controls.Add(this.fileBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.TextBox fileBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button longestBtn;
        private System.Windows.Forms.TextBox longestBox;
        private System.Windows.Forms.Button vowelsBtn;
        private System.Windows.Forms.TextBox vowelBox;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.Button firstBtn;
    }
}

