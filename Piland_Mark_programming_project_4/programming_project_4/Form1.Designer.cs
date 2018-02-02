namespace programming_project_4
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
            this.b11 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.b13 = new System.Windows.Forms.Button();
            this.b21 = new System.Windows.Forms.Button();
            this.b22 = new System.Windows.Forms.Button();
            this.b23 = new System.Windows.Forms.Button();
            this.b31 = new System.Windows.Forms.Button();
            this.b32 = new System.Windows.Forms.Button();
            this.b33 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.p1score = new System.Windows.Forms.Label();
            this.p2score = new System.Windows.Forms.Label();
            this.newgameBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            // 
            // b11
            // 
            this.b11.Location = new System.Drawing.Point(27, 76);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(110, 79);
            this.b11.TabIndex = 1;
            this.b11.UseVisualStyleBackColor = true;
            this.b11.Click += new System.EventHandler(this.b11_Click);
            // 
            // b12
            // 
            this.b12.Location = new System.Drawing.Point(163, 76);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(110, 79);
            this.b12.TabIndex = 2;
            this.b12.UseVisualStyleBackColor = true;
            this.b12.Click += new System.EventHandler(this.b12_Click);
            // 
            // b13
            // 
            this.b13.Location = new System.Drawing.Point(300, 76);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(110, 79);
            this.b13.TabIndex = 3;
            this.b13.UseVisualStyleBackColor = true;
            this.b13.Click += new System.EventHandler(this.b13_Click);
            // 
            // b21
            // 
            this.b21.Location = new System.Drawing.Point(27, 188);
            this.b21.Name = "b21";
            this.b21.Size = new System.Drawing.Size(110, 79);
            this.b21.TabIndex = 4;
            this.b21.UseVisualStyleBackColor = true;
            this.b21.Click += new System.EventHandler(this.b21_Click);
            // 
            // b22
            // 
            this.b22.Location = new System.Drawing.Point(159, 188);
            this.b22.Name = "b22";
            this.b22.Size = new System.Drawing.Size(110, 79);
            this.b22.TabIndex = 5;
            this.b22.UseVisualStyleBackColor = true;
            this.b22.Click += new System.EventHandler(this.b22_Click);
            // 
            // b23
            // 
            this.b23.Location = new System.Drawing.Point(300, 188);
            this.b23.Name = "b23";
            this.b23.Size = new System.Drawing.Size(110, 79);
            this.b23.TabIndex = 6;
            this.b23.UseVisualStyleBackColor = true;
            this.b23.Click += new System.EventHandler(this.b23_Click);
            // 
            // b31
            // 
            this.b31.Location = new System.Drawing.Point(27, 290);
            this.b31.Name = "b31";
            this.b31.Size = new System.Drawing.Size(110, 79);
            this.b31.TabIndex = 7;
            this.b31.UseVisualStyleBackColor = true;
            this.b31.Click += new System.EventHandler(this.b31_Click);
            // 
            // b32
            // 
            this.b32.Location = new System.Drawing.Point(159, 290);
            this.b32.Name = "b32";
            this.b32.Size = new System.Drawing.Size(110, 79);
            this.b32.TabIndex = 8;
            this.b32.UseVisualStyleBackColor = true;
            this.b32.Click += new System.EventHandler(this.b32_Click);
            // 
            // b33
            // 
            this.b33.Location = new System.Drawing.Point(300, 290);
            this.b33.Name = "b33";
            this.b33.Size = new System.Drawing.Size(110, 79);
            this.b33.TabIndex = 9;
            this.b33.UseVisualStyleBackColor = true;
            this.b33.Click += new System.EventHandler(this.b33_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Player 1 Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Player 2 Score";
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(184, 391);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(108, 52);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset Score";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // p1score
            // 
            this.p1score.Location = new System.Drawing.Point(24, 423);
            this.p1score.Name = "p1score";
            this.p1score.Size = new System.Drawing.Size(100, 23);
            this.p1score.TabIndex = 13;
            // 
            // p2score
            // 
            this.p2score.Location = new System.Drawing.Point(391, 420);
            this.p2score.Name = "p2score";
            this.p2score.Size = new System.Drawing.Size(100, 23);
            this.p2score.TabIndex = 14;
            // 
            // newgameBtn
            // 
            this.newgameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgameBtn.Location = new System.Drawing.Point(432, 124);
            this.newgameBtn.Name = "newgameBtn";
            this.newgameBtn.Size = new System.Drawing.Size(85, 79);
            this.newgameBtn.TabIndex = 15;
            this.newgameBtn.Text = "New Game";
            this.newgameBtn.UseVisualStyleBackColor = true;
            this.newgameBtn.Click += new System.EventHandler(this.newgameBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(432, 251);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(85, 79);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "Exit Game";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 455);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.newgameBtn);
            this.Controls.Add(this.p2score);
            this.Controls.Add(this.p1score);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b33);
            this.Controls.Add(this.b32);
            this.Controls.Add(this.b31);
            this.Controls.Add(this.b23);
            this.Controls.Add(this.b22);
            this.Controls.Add(this.b21);
            this.Controls.Add(this.b13);
            this.Controls.Add(this.b12);
            this.Controls.Add(this.b11);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b11;
        private System.Windows.Forms.Button b12;
        private System.Windows.Forms.Button b13;
        private System.Windows.Forms.Button b21;
        private System.Windows.Forms.Button b22;
        private System.Windows.Forms.Button b23;
        private System.Windows.Forms.Button b31;
        private System.Windows.Forms.Button b32;
        private System.Windows.Forms.Button b33;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label p1score;
        private System.Windows.Forms.Label p2score;
        private System.Windows.Forms.Button newgameBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

