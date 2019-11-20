using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormCalcApp
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void Calc_Load(object sender, EventArgs e)
        {

        }

        
        private void btnclear_Click(object sender, EventArgs e)
        {
            this.result.ResetText();
            this.operatorpreview1.ResetText();
            this.numpreview1.ResetText();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.result.Text += '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.result.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.result.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.result.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.result.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.result.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.result.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.result.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.result.Text += '9';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.result.Text += '0';
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void btnperiod_Click(object sender, EventArgs e)
        {
            this.result.Text += '.';
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            this.operatorpreview1.Text = "+";
            if (this.result.Text != "")
            {
                numpreview1.Text = this.result.Text;
            }
            this.result.ResetText();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            this.operatorpreview1.Text = "-";
            if (this.result.Text != "")
            {
                numpreview1.Text = this.result.Text;
            }
            this.result.ResetText();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            this.operatorpreview1.Text = "x";
            if (this.result.Text != "")
            {
                numpreview1.Text = this.result.Text;
            }
            this.result.ResetText();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            this.operatorpreview1.Text = "/";


            if (this.result.Text != "")
            {
                numpreview1.Text = this.result.Text;
            }

            this.result.ResetText();
        }

        private void btneq_Click(object sender, EventArgs e)
        {
            this.operatorpreview1.Text = "=";
            if (this.result.Text != "")
            {
                numpreview1.Text = this.result.Text;
            }
            this.result.ResetText();
        }
    }
}
