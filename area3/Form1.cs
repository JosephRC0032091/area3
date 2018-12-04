using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            try


            {

                int UserInput;
                UserInput = int.Parse(textBox1.Text);
                
                double area = Math.Pow(UserInput , 1.0/3.0);
                textBox3.Text = area.ToString();
            }
            catch
            {
                MessageBox.Show("Enter An Integer Please");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
