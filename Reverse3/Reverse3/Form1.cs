using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reverse3
{
    public partial class Form1 : Form
    {
        private int[] array = { 999999, 999999, 999999};
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < array.Length; ++i)
                {
                    if (array[0] == 999999)
                    {
                        array[0] = Convert.ToInt32(textBox1.Text);
                        label1.Text = "Value 1: " + array[0];
                        break;
                    } else if (array[1] == 999999)
                    {
                        array[1] = Convert.ToInt32(textBox1.Text);
                        label2.Text = "Value 2: " + array[1];
                        break;
                    } else if (array[2] == 999999)
                    {
                        array[2] = Convert.ToInt32(textBox1.Text);
                        label3.Text = "Value 3: " + array[2];
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Values are full. Please reset to continue.");
                        break;
                    }
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("Invalid values entered");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Reverse(array);
            label1.Text = "Value 1: " + array[0];
            label2.Text = "Value 2: " + array[1];
            label3.Text = "Value 3: " + array[2];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            array[0] = 999999;
            array[1] = 999999;
            array[2] = 999999;
            label1.Text = "Value 1: ";
            label2.Text = "Value 2: ";
            label3.Text = "Value 3: ";
        }
    }
}
