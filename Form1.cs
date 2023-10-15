using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Media;

namespace FastTyping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Time = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0) 
            {
                Time = 59;
                
               
            }else if(comboBox1.SelectedIndex == 1)
            {
                Time = 179;
                
            }else
            {
                Time = 299;
               
            }
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 0)
            {
                
                txtShow.Text = "Spoken by more than 100 million people," +
                    " Urdu is the official language of Pakistan. It’s also" +
                    " widely spoken in India and places that have large numbers " +
                    "of expats from these countrie...";
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                txtShow.Text = "The acronym “SOS” is used when sending messages via text" +
                    " or internet messaging systems. According to PC.net, there are several" +
                    " meanings behind this acronym. If you want to warn som...";
            }else
            {
                txtShow.Text = "Do you ever need to convert audio files to text? It can be handy" +
                    " for a lot of reasons. Maybe you want to be able to read a book while you’re" +
                    " working out, or maybe you want to be ab...";
            }
            Text = txtShow.Text;
        }
        private int Count = 0, ErrorChar = 0, CorrectCahr = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }

        private void txtTyping_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            txtTyping.Enabled = true;
            txtTyping.Focus();
            lblCounter.Visible = true;
            timer1.Enabled = true;
        }

        private void txtTyping_TextChanged(object sender, EventArgs e)
        {
            if(txtTyping.Enabled == false)
            {
                MessageBox.Show("Choose Time", "Title", MessageBoxButtons.OK);
            }
            char ch;
            ch = txtTyping.Text[txtTyping.Text.Length - 1];
            if (!(ch == txtShow.Text[Count]))
            {
                txtTyping.ForeColor = Color.Red;
                SystemSounds.Beep.Play();
                ErrorChar++;
            }
            else
            {
                txtTyping.ForeColor = Color.Green;
                CorrectCahr++;
            }
            Count++;
        }
        //private int Counter = Time;
        private void timer1_Tick(object sender, EventArgs e)
        {

            Time--;
            lblCounter.Text = Time.ToString();
            if (Time == 0)
            {
                timer1.Enabled = false;
                txtTyping.ReadOnly = true;
                MessageBox.Show("" +
                    "finished Timer, Press OK to Know Your Result", "Title", MessageBoxButtons.OK);
                Form frm = new Form2(ErrorChar, CorrectCahr);
                
                frm.ShowDialog();
                
            }
        }
    }
}
