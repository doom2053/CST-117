namespace My_first_project
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
            this.showAnswerButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showAnswerButton
            // 
            this.showAnswerButton.Location = new System.Drawing.Point(118, 147);
            this.showAnswerButton.Name = "showAnswerButton";
            this.showAnswerButton.Size = new System.Drawing.Size(110, 23);
            this.showAnswerButton.TabIndex = 0;
            this.showAnswerButton.Text = "Click Me";
            this.showAnswerButton.UseVisualStyleBackColor = true;
            this.showAnswerButton.Click += new System.EventHandler(this.showAnswerButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.questionLabel.Location = new System.Drawing.Point(68, 24);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(254, 43);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "What Former U.S. president is known for a top hat?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerLabel
            // 
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(12, 77);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(360, 56);
            this.answerLabel.TabIndex = 2;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 190);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.showAnswerButton);
            this.Name = "Form1";
            this.Text = "My First Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showAnswerButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answerLabel;
    }
}

