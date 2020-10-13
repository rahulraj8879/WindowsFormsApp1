using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int num;
            double prime, square_root;

            try
            {
                prime = Double.Parse(textBox1.Text);

                square_root = Math.Sqrt(prime);
                for (num = 2; num <= square_root; num++)
                {
                    if (prime % num == 0)
                    {
                        MessageBox.Show(prime + " is not a Prime Number");
                        break;
                    }
                }
                if (num > square_root)
                {
                    MessageBox.Show(prime + " is a prime number");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Enter a valid Number");
            }
           
           
                
           

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
