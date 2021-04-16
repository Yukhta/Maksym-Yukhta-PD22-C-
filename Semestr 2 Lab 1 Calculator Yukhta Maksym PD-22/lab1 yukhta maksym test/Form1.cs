using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator12
{
 public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        double a = 0, b = 0, c = 0;
        char symbol = '+';

private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        bool symbol1 = true;

private void button18_Click(object sender, EventArgs e)
        {
            if (symbol1 == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                symbol1 = false;
            }
            else if (symbol1 == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                symbol1 = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double koren, res;
            koren = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(koren);
            textBox1.Text = res.ToString();
        }

private void button22_Click(object sender, EventArgs e)
        {
            double kvadrat, res;
            kvadrat = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(kvadrat,2);
            textBox1.Text = res.ToString();
        }
 private void button20_Click(object sender, EventArgs e)
        {
            double n, res;
            n = Convert.ToDouble(textBox1.Text);
            res = 1/n;
            textBox1.Text = res.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            b= Convert.ToDouble(textBox1.Text);
            switch (symbol)
            {
                case '+': c = a + b;
                    break;
                case '-': c = a - b;
                    break;
                case '*': c = a * b;
                    break;
                case '/': c = a / b;
                    break;
            }
            textBox1.Text = c.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            symbol = (sender as Button).Text[0];
            textBox1.Clear();
        }
    }
}
