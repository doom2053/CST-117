namespace WindowsFormsApp1
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
            this.textconvert = new System.Windows.Forms.TextBox();
            this.Calculatebtn = new System.Windows.Forms.Button();
            this.Outcomelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter in Seconds";
            // 
            // textconvert
            // 
            this.textconvert.Location = new System.Drawing.Point(135, 125);
            this.textconvert.Name = "textconvert";
            this.textconvert.Size = new System.Drawing.Size(100, 20);
            this.textconvert.TabIndex = 1;
            // 
            // Calculatebtn
            // 
            this.Calculatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculatebtn.Location = new System.Drawing.Point(107, 162);
            this.Calculatebtn.Name = "Calculatebtn";
            this.Calculatebtn.Size = new System.Drawing.Size(154, 66);
            this.Calculatebtn.TabIndex = 2;
            this.Calculatebtn.Text = "Calculate";
            this.Calculatebtn.UseVisualStyleBackColor = true;
            this.Calculatebtn.Click += new System.EventHandler(this.Calculatebtn_Click);
            // 
            // Outcomelbl
            // 
            this.Outcomelbl.Location = new System.Drawing.Point(107, 263);
            this.Outcomelbl.Name = "Outcomelbl";
            this.Outcomelbl.Size = new System.Drawing.Size(161, 23);
            this.Outcomelbl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 335);
            this.Controls.Add(this.Outcomelbl);
            this.Controls.Add(this.Calculatebtn);
            this.Controls.Add(this.textconvert);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textconvert;
        private System.Windows.Forms.Button Calculatebtn;
        private System.Windows.Forms.Label Outcomelbl;
    }
}

