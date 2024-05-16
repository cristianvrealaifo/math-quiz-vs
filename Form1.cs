using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aretet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random vari = new Random();
            label1.Text = vari.Next(1, 999).ToString();
            label4.Text = vari.Next(1, 999).ToString();
            label5.Text = vari.Next(1, 999).ToString();
            label6.Text = vari.Next(1, 999).ToString();
            label3.Text = vari.Next(1, 999).ToString();
            label10.Text = vari.Next(1, 999).ToString();
            label11.Text = vari.Next(1, 999).ToString();
            label12.Text = vari.Next(1, 999).ToString();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num = Int32.Parse(textBox1.Text);
            num -= 1;

            textBox1.Text = num.ToString();
        }
    }
}
