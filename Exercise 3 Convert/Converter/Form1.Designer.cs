namespace Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fahrenheitLabel = new System.Windows.Forms.Label();
            this.TemperatureBox = new System.Windows.Forms.TextBox();
            this.convertbutton = new System.Windows.Forms.Button();
            this.CelsiusTempBox = new System.Windows.Forms.Label();
            this.celsiusBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fahrenheitLabel
            // 
            this.fahrenheitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrenheitLabel.Location = new System.Drawing.Point(16, 31);
            this.fahrenheitLabel.Name = "fahrenheitLabel";
            this.fahrenheitLabel.Size = new System.Drawing.Size(243, 23);
            this.fahrenheitLabel.TabIndex = 0;
            this.fahrenheitLabel.Text = "Enter Fahrenheit Here";
            // 
            // TemperatureBox
            // 
            this.TemperatureBox.Location = new System.Drawing.Point(66, 68);
            this.TemperatureBox.Name = "TemperatureBox";
            this.TemperatureBox.Size = new System.Drawing.Size(133, 20);
            this.TemperatureBox.TabIndex = 1;
            // 
            // convertbutton
            // 
            this.convertbutton.Location = new System.Drawing.Point(89, 110);
            this.convertbutton.Name = "convertbutton";
            this.convertbutton.Size = new System.Drawing.Size(94, 46);
            this.convertbutton.TabIndex = 2;
            this.convertbutton.Text = "Convert";
            this.convertbutton.UseVisualStyleBackColor = true;
            this.convertbutton.Click += new System.EventHandler(this.convertbutton_Click);
            // 
            // CelsiusTempBox
            // 
            this.CelsiusTempBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelsiusTempBox.Location = new System.Drawing.Point(12, 170);
            this.CelsiusTempBox.Name = "CelsiusTempBox";
            this.CelsiusTempBox.Size = new System.Drawing.Size(247, 23);
            this.CelsiusTempBox.TabIndex = 4;
            this.CelsiusTempBox.Text = "Celsius Temperature Here:";
            this.CelsiusTempBox.Click += new System.EventHandler(this.Label2_Click);
            // 
            // celsiusBox
            // 
            this.celsiusBox.Location = new System.Drawing.Point(66, 208);
            this.celsiusBox.Name = "celsiusBox";
            this.celsiusBox.Size = new System.Drawing.Size(133, 23);
            this.celsiusBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.celsiusBox);
            this.Controls.Add(this.CelsiusTempBox);
            this.Controls.Add(this.convertbutton);
            this.Controls.Add(this.TemperatureBox);
            this.Controls.Add(this.fahrenheitLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fahrenheitLabel;
        private System.Windows.Forms.TextBox TemperatureBox;
        private System.Windows.Forms.Button convertbutton;
        private System.Windows.Forms.Label CelsiusTempBox;
        private System.Windows.Forms.Label celsiusBox;
    }
}

