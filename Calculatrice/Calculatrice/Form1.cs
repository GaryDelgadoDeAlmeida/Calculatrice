using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        private double res = 0;
        private char operat;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += this.btnNumber0.Text;
        }

        private void btnNumber1_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += this.btnNumber1.Text;
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += this.btnNumber2.Text;
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += this.btnNumber3.Text;
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += this.btnNumber4.Text;
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += this.btnNumber5.Text;
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += this.btnNumber6.Text;
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += this.btnNumber7.Text;
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += this.btnNumber8.Text;
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += this.btnNumber9.Text;
        }

        private void btnVirgule_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += this.btnVirgule.Text;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.res == 0)
                {
                    this.res = Convert.ToDouble(this.txtResult.Text);
                    this.operat = Convert.ToChar(this.btnMultiplication.Text);
                    this.txtResult.Text = null;
                }
                else
                {
                    this.res = this.res * Convert.ToDouble(this.txtResult.Text);
                    this.txtResult.Text = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.res == 0)
                {
                    this.res = Convert.ToDouble(this.txtResult.Text);
                    this.operat = Convert.ToChar(this.btnAddition.Text);
                    this.txtResult.Text = null;
                }
                else
                {
                    this.res = this.res + Convert.ToDouble(this.txtResult.Text);
                    this.txtResult.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoustraction_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.res == 0)
                {
                    this.res = Convert.ToDouble(this.txtResult.Text);
                    this.operat = Convert.ToChar(this.btnSoustraction.Text);
                    this.txtResult.Text = null;
                }
                else
                {
                    this.res = this.res - Convert.ToDouble(this.txtResult.Text);
                    this.txtResult.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.res == 0)
                {
                    this.res = Convert.ToDouble(this.txtResult.Text);
                    this.operat = Convert.ToChar(this.btnDivision.Text);
                    this.txtResult.Text = null;
                }
                else
                {
                    this.res = this.res / Convert.ToDouble(this.txtResult.Text);
                    this.txtResult.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double result = 0;

            switch(this.operat)
            {
                case '/':
                    result = this.res / Convert.ToDouble(this.txtResult.Text);
                    break;

                case 'x':
                    result = this.res * Convert.ToDouble(this.txtResult.Text);
                    break;

                case '+':
                    result = this.res + Convert.ToDouble(this.txtResult.Text);
                    break;

                case '-':
                    result = this.res - Convert.ToDouble(this.txtResult.Text);
                    break;
            }

            this.txtResult.Text = result.ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(this.txtResult.Text.Length > 0)
            {
                this.txtResult.Text = this.txtResult.Text.Substring(0, this.txtResult.Text.Length - 1);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = null;
            this.res = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = null;
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            this.res = -this.res;
            this.txtResult.Text = (this.res).ToString();
        }
    }
}
