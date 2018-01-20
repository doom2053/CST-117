namespace Inventory
{
    partial class CellPhoneInventory
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addPhoneButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.phoneListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select a Phone";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Cell Phone Data";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Brand:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price:";
            // 
            // addPhoneButton
            // 
            this.addPhoneButton.Location = new System.Drawing.Point(73, 205);
            this.addPhoneButton.Name = "addPhoneButton";
            this.addPhoneButton.Size = new System.Drawing.Size(104, 44);
            this.addPhoneButton.TabIndex = 9;
            this.addPhoneButton.Text = "Add Phone";
            this.addPhoneButton.UseVisualStyleBackColor = true;
            this.addPhoneButton.Click += new System.EventHandler(this.addPhoneButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(279, 205);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 44);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(73, 76);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(100, 20);
            this.brandTextBox.TabIndex = 11;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(73, 115);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 12;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(73, 158);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 13;
            // 
            // phoneListBox
            // 
            this.phoneListBox.FormattingEnabled = true;
            this.phoneListBox.Location = new System.Drawing.Point(279, 76);
            this.phoneListBox.Name = "phoneListBox";
            this.phoneListBox.Size = new System.Drawing.Size(120, 95);
            this.phoneListBox.TabIndex = 14;
            this.phoneListBox.SelectedIndexChanged += new System.EventHandler(this.phoneListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mark Piland";
            // 
            // CellPhoneInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneListBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addPhoneButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "CellPhoneInventory";
            this.Text = "CellPhone Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addPhoneButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ListBox phoneListBox;
        private System.Windows.Forms.Label label6;
    }
}

