using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit7B
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Arg1 = 0;
            this.Arg2 = 0;
            this.ResultXY = 0;
            this.ResultXX=0;
        }

        int Arg1
        {
            get
            {
                return Convert.ToInt32(XTextBox.Text);
            }
            set
            {
                XTextBox.Text = value.ToString();
            }
        }

        int Arg2
        {
            get
            {
                return Convert.ToInt32(YTextBox.Text);
            }
            set
            {
                YTextBox.Text = value.ToString();
            }
        }
        int Arg
        {
            get
            {
                return Convert.ToInt32(XTextBox2.Text);
            }
            set
            {
                XTextBox2.Text = value.ToString();
            }
        }

        double ResultXY
        {
            set
            {
                ResultXYBox.Text = value.ToString("# ### ### ##0.0##");
            }

        }

        double ResultXX
        {
            set
            {
                ResultX.Text = value.ToString("# ### ### ##0.0##");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Arg1 = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Arg2 = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ResultXY = this.Arg1 * this.Arg2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.ResultXY = this.Arg1 + this.Arg2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ResultXY = this.Arg1 - this.Arg2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ResultXY = this.Arg1 / this.Arg2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Arg = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.ResultXX = Math.Sqrt(this.Arg);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.ResultXX = Math.Log(this.Arg);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.ResultXX = Math.Log10(this.Arg);
        }

        private void ResultXYBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
