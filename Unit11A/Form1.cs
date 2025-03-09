using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit11A
{
    public partial class Form1: Form
    {
        double _ResultDelta = 0;
        public Form1()
        {
            InitializeComponent();
            this.Arg1 = 0;
            this.Arg2 = 0;
            this.Arg3 = 0;
            this.ResultDelta = 0;
            this.ResultX1 = 0.000;
            this.ResultX2 = 0.000;

        }

        int Arg1
        {
            get
            {
                return Convert.ToInt32(ATextBox.Text);
            }
            set
            {
                ATextBox.Text = value.ToString();
            }
        }

        int Arg2
        {
            get
            {
                return Convert.ToInt32(BTextBox.Text);
            }
            set
            {
                BTextBox.Text = value.ToString();
            }
        }

        int Arg3
        {
            get
            {
                return Convert.ToInt32(CTextBox.Text);
            }
            set
            {
                CTextBox.Text = value.ToString();
            }
        }

      double ResultDelta
        {
            get
            {
                return _ResultDelta;
            }
            set
            {
                _ResultDelta = value;
                ResultDeltaBox.Text = value.ToString ("# ### ### ##0.0##");
            }
        }

        double ResultX1
        {
            set
            {
                ResultX1Box.Text = value.ToString("# ### ### ##0.0##");
            }
        }

        double ResultX2
        {
            set
            {
                ResultX2Box.Text = value.ToString("# ### ### ##0.0##");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.ResultDelta = (this.Arg2) ^ 2 - 4 * this.Arg1 * this.Arg3;
            this.ResultDelta = Math.Pow(this.Arg2, 2) - 4 * this.Arg1 * this.Arg3;

            if (this.ResultDelta>0)
            {
                this.ResultX1 = (-this.Arg2 - Math.Sqrt(this.ResultDelta)) / (2 * this.Arg1);
                this.ResultX2 = (-this.Arg2 + Math.Sqrt(this.ResultDelta)) / (2 * this.Arg1);
            }
            else if (this.ResultDelta==0)
            {
                this.ResultX1 = this.ResultX2 = -this.Arg2 / (2 * this.Arg1);
            }
            else
            {
                MessageBox.Show("Brak rozwiązań w liczbach rzeczywistych.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
