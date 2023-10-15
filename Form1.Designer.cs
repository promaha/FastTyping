namespace FastTyping
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
            this.txtTyping = new System.Windows.Forms.TextBox();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblTexts = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCounter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTyping
            // 
            this.txtTyping.BackColor = System.Drawing.Color.White;
            this.txtTyping.Enabled = false;
            this.txtTyping.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTyping.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTyping.Location = new System.Drawing.Point(613, 442);
            this.txtTyping.Multiline = true;
            this.txtTyping.Name = "txtTyping";
            this.txtTyping.Size = new System.Drawing.Size(498, 225);
            this.txtTyping.TabIndex = 0;
            this.txtTyping.TextChanged += new System.EventHandler(this.txtTyping_TextChanged);
            this.txtTyping.Validating += new System.ComponentModel.CancelEventHandler(this.txtTyping_Validating);
            // 
            // txtShow
            // 
            this.txtShow.BackColor = System.Drawing.Color.White;
            this.txtShow.Enabled = false;
            this.txtShow.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShow.ForeColor = System.Drawing.Color.Black;
            this.txtShow.Location = new System.Drawing.Point(613, 147);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(498, 211);
            this.txtShow.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightCoral;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 minut",
            "3 minuts",
            "5 minuts"});
            this.comboBox1.Location = new System.Drawing.Point(102, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.LightCoral;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Text 1",
            "Text 2",
            "Text 3"});
            this.comboBox2.Location = new System.Drawing.Point(102, 119);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(253, 28);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblTexts
            // 
            this.lblTexts.AutoSize = true;
            this.lblTexts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexts.Location = new System.Drawing.Point(12, 115);
            this.lblTexts.Name = "lblTexts";
            this.lblTexts.Size = new System.Drawing.Size(84, 29);
            this.lblTexts.TabIndex = 4;
            this.lblTexts.Text = "Texts:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(16, 213);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 29);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCounter
            // 
            this.lblCounter.BackColor = System.Drawing.Color.LightSalmon;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(36, 317);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(156, 75);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Original Text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(608, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 59);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fast Typing";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MistyRose;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(21, 555);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(334, 74);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1152, 676);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTexts);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.txtTyping);
            this.Name = "Form1";
            this.Text = "Fast Typing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTyping;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblTexts;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnStart;
    }
}

