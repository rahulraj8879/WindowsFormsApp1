using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num;
                long fact;
                num = Int32.Parse(textBox1.Text);
                if (num > 2 )
                {
                    MessageBox.Show(" Numbers upto 25 are allowed");
                }
               
                fact = 1;
                while (num >= 1 && num <= 25)
                {
                    fact *= num;
                    num--;
                }
                textBox2.Text = fact + " ";
            }catch(Exception ee)
            {
                MessageBox.Show("Enter a valid number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
