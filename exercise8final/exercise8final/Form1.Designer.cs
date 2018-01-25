namespace exercise8final
{
    partial class Exercise8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise8));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fatTextbox = new System.Windows.Forms.TextBox();
            this.carbsTextbox = new System.Windows.Forms.TextBox();
            this.calfatLbl = new System.Windows.Forms.Label();
            this.calCarbsLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.convertBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calories from Fat and Carbs Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fat Grams:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Carbs Grams:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Calories from Fat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Calories from Carbs:";
            // 
            // fatTextbox
            // 
            this.fatTextbox.Location = new System.Drawing.Point(202, 98);
            this.fatTextbox.Name = "fatTextbox";
            this.fatTextbox.Size = new System.Drawing.Size(150, 20);
            this.fatTextbox.TabIndex = 6;
            // 
            // carbsTextbox
            // 
            this.carbsTextbox.Location = new System.Drawing.Point(202, 149);
            this.carbsTextbox.Name = "carbsTextbox";
            this.carbsTextbox.Size = new System.Drawing.Size(150, 20);
            this.carbsTextbox.TabIndex = 7;
            // 
            // calfatLbl
            // 
            this.calfatLbl.Location = new System.Drawing.Point(199, 220);
            this.calfatLbl.Name = "calfatLbl";
            this.calfatLbl.Size = new System.Drawing.Size(153, 21);
            this.calfatLbl.TabIndex = 8;
            // 
            // calCarbsLbl
            // 
            this.calCarbsLbl.Location = new System.Drawing.Point(199, 278);
            this.calCarbsLbl.Name = "calCarbsLbl";
            this.calCarbsLbl.Size = new System.Drawing.Size(153, 21);
            this.calCarbsLbl.TabIndex = 9;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(292, 324);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(98, 49);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(152, 324);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(98, 49);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(12, 324);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(98, 49);
            this.convertBtn.TabIndex = 12;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // Exercise8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 385);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calCarbsLbl);
            this.Controls.Add(this.calfatLbl);
            this.Controls.Add(this.carbsTextbox);
            this.Controls.Add(this.fatTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exercise8";
            this.Text = "Fat and Carbs Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fatTextbox;
        private System.Windows.Forms.TextBox carbsTextbox;
        private System.Windows.Forms.Label calfatLbl;
        private System.Windows.Forms.Label calCarbsLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button convertBtn;
    }
}

