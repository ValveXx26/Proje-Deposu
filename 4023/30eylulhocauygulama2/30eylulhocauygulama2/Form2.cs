using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30eylulhocauygulama2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            this.Text = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Form1 f = new Form1();
            f.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
               
        }
    }
}
