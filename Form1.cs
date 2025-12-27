using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private double input;
        private double input2;
        private string sign;

        private void button1_Click(object sender, EventArgs e)
        {
            tb.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tb.Text.Contains("/")) return;
            input = double.Parse(tb.Text);
            sign = "/";
            tb.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tb.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tb.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tb.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tb.Text.Contains("X")) return;
            input = double.Parse(tb.Text);
            sign = "X";
            tb.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tb.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tb.Text += "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tb.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tb.Text.Contains("+")) return;
            input = double.Parse(tb.Text);
            sign = "+";
            tb.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tb.Text += "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tb.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (tb.Text.Contains(".")) return;
            tb.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (tb.Text.Contains("-")) return;
            input = double.Parse(tb.Text);
            sign = "-";
            tb.Text = "";
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            var input2 = double.Parse(tb.Text);
            if (sign == "+")
            {
                var res = input + input2;
                tb.Text = res.ToString();
                ///to change
                //input2 = 0;
                //input = 0;
            }
            else if (sign == "X")
            {
                var res = input * input2;
                tb.Text = res.ToString();
                //input2 = 0;
                //input = 0;
            }
            else if (sign == "/")
            {
                var res = input / input2;
                tb.Text = res.ToString();
                //input2 = 0;
                //input = 0;
            }
            else if(sign == "-")
            {
                var res = input - input2;
                tb.Text = res.ToString();
                //input2 = 0;
                //input = 0;
            }
        }
    }
}
