using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastTyping
{
    public partial class Form2 : Form
    {
        int ErrorChar1 = 0, CorrectCahr1 = 0;
        public Form2(int  ErrorChar, int CorrectCahr)
        {
            InitializeComponent();
            ErrorChar1 = ErrorChar; CorrectCahr1 = CorrectCahr;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblCorrect.Text = CorrectCahr1.ToString();
            lblWrong.Text = ErrorChar1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
