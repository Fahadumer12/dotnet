using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double no1,no2,result;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text=textBox.Text+("1");
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            no2 = Convert.ToInt16(textBox.Text);
            result = no1 + no2;
            textBox.Text = ("");
            textBox.Text=textBox.Text+(result);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ("2");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ("3");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ("4");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ("5");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ("6");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ("7");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ("8");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ("9");

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ("0");

        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
           
             no1 = Convert.ToInt16( textBox.Text);
            textBox.Text =  ("");

        }
    }
}
