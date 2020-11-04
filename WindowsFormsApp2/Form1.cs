using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        public int a, b, operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 3;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
            
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = textBox1.Text + 0;
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 2);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 8);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 16);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 4;
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            b = int.Parse(textBox1.Text);

            switch (operation)
            {
                case 1:
                    {
                        int result = a + b;
                        textBox1.Text = result.ToString(); 
                        break;
                    }
                case 2:
                    { 
                        int result = a - b;
                        textBox1.Text = result.ToString();
                        break;
                    }
                case 3:
                    {
                        int result = a * b;
                        textBox1.Text = result.ToString();
                        break;
                    }
                case 4:
                    {
                        int result = a / b;
                        textBox1.Text = result.ToString();
                        break;
                    }
            }
        }
    }
}
