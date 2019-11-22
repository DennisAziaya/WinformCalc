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
            double fn;
            double sn;
            double r;

            double.TryParse(this.result.Text, out fn);
            double.TryParse(this.numpreview1.Text, out sn);
            r = 0;

            if (this.operatorpreview1.Text == this.btnplus.Text)
            {
                r = fn + sn;
            }


            if (this.operatorpreview1.Text == this.btnsub.Text)
            {
                r = sn - fn;
            }

            if (this.operatorpreview1.Text == this.btnmultiply.Text)
            {
                r = fn * sn;
            }

            if (this.operatorpreview1.Text == this.btndivide.Text)
            {
                r = sn / fn;
            }

            this.result.Text = r.ToString();
            this.operatorpreview1.ResetText();
            this.numpreview1.ResetText();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timelabel.Text = DateTime.UtcNow.ToString();
        }

        private void Calc_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Are You Sure?");
        }

        private void btn0_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    this.result.Text += '0';
                    break;
                
                case Keys.NumPad1:
                    this.result.Text += '1';
                    break;

                case Keys.NumPad2:
                    this.result.Text += '2';
                    break;
                
                case Keys.NumPad3:
                    this.result.Text += '3';
                    break;
                
                case Keys.NumPad4:
                    this.result.Text += '4';
                    break;
                
                case Keys.NumPad5:
                    this.result.Text += '5';
                    break;
                
                case Keys.NumPad6:
                    this.result.Text += '6';
                    break;
                
                case Keys.NumPad7:
                    this.result.Text += '7';
                    break;
                
                case Keys.NumPad8:
                    this.result.Text += '8';
                    break;
                
                case Keys.NumPad9:
                    this.result.Text += '9';
                    break;
                
                case Keys.OemPeriod:
                    this.result.Text += '.';
                    break;
                
                case Keys.Subtract:
                    btnsub_Click(sender, e);
                    break;
                
                case Keys.Add:
                    btnplus_Click(sender, e);
                    break;
                
                case Keys.Multiply:
                    btnmultiply_Click(sender,e);
                    break;

                case Keys.Divide:
                    btndivide_Click(sender, e);
                    break;

                case Keys.Execute:
                    btneq_Click(sender, e);
                    break;
            }

            

        }
    }
}
