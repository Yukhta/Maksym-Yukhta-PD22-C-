using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2YukhtaMaksym
{
public partial class Form1 : Form
    {
        int a = 0;
        int top = 80;
        int left = 100;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            BuildButtons();
        }

private void DeleteButtons()
        {
            for (int i = 0; i < 16; i++)
            {
                tabPage2.Controls.RemoveByKey("btn" + i);
            }
            top = 80;
            left = 100;
            i = 0;
            a = 0;
        }
private void BuildButtons()
        {
            for (i = 0; i < 16; i++)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                button.Name = "btn" + i;
                button.Text = $"{i + 1}".ToString();
                button.Click += ButtonOnClick;

                tabPage2.Controls.Add(button);
                top += button.Height + 5;

                if (((i + 1) % 4) == 0 && i != 0)
                {
                    top = 80;
                    left += button.Width + 5;
                }
            }
        }
 private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }
private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count >= 0)
            {
                if (comboBox1.SelectedIndex >= 0)
                {
                    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                    comboBox1.Text = "";
                }
            }
        }
private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;

            if (button != null)
            {
                if (button.Text == (a + 1).ToString())
                {
                    button.Dispose();
                    a++;
                }
                else
                {
                    DeleteButtons();
                    BuildButtons();
                }
                if (a == 16)
                {
                    textBox2.Text = "Ось так! Молодець!";
                    DeleteButtons();
                    BuildButtons();
                }
            }
        }
private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
