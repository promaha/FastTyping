namespace FastTyping
{
    partial class Form2
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
            this.lblCorrect = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correct Char:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCorrect.Location = new System.Drawing.Point(271, 75);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(144, 52);
            this.lblCorrect.TabIndex = 1;
            this.lblCorrect.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wrong Char:";
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWrong.Location = new System.Drawing.Point(271, 211);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(144, 52);
            this.lblWrong.TabIndex = 3;
            this.lblWrong.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(398, 52);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Words:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(271, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 52);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(259, 432);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 67);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(755, 522);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
    }
}