namespace at_yarışı_deneme_1
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        int para = 0;


        public Form1()
        {
            InitializeComponent();
            finishLine.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            finishLine.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Image = Image.FromFile("Golden.gif");
            pictureBox2.Image = Image.FromFile("Golden.gif");
            pictureBox3.Image = Image.FromFile("Golden.gif");
            pictureBox4.Image = Image.FromFile("Golden.gif");





        }

        public void timer1_Tick(object sender, EventArgs e)

        {
            Random rnd = new Random();
            int h1, h2, h3,h4, kupon;
      
            kupon = 1000;

            h1 = rnd.Next(10, 31);
            h2 = rnd.Next(10, 31);
            h3 = rnd.Next(10, 31);
            h4 = rnd.Next(10, 31);
            pictureBox1.Left += h1;
            pictureBox2.Left += h2;
            pictureBox3.Left += h3;
            pictureBox4.Left += h4;

            if (pictureBox1.Right >= finishLine.Left)
            {
                timer1.Stop();
                MessageBox.Show("1. At kazandı!");
                if (radioButton1.Checked == true)
                {

                    para += kupon;
                    label5.Text = para.ToString();
                }
                else
                {

                    para -= kupon;
                    label5.Text = para.ToString();
                }
            }
            else if (pictureBox2.Right >= finishLine.Left)
            {
                timer1.Stop();
                MessageBox.Show("2. At kazandı!");
                if (radioButton2.Checked == true)
                {

                    para += kupon;
                    label5.Text = para.ToString();
                }
                else
                {
                    ;
                    para -= kupon;
                    label5.Text = para.ToString();
                }
            }
            else if (pictureBox3.Right >= finishLine.Left)
            {
                timer1.Stop();
                MessageBox.Show("3. At kazandı!");
                if (radioButton3.Checked == true)
                {

                    para += kupon;
                    label5.Text = para.ToString();
                }
                else
                {

                    para -= kupon;
                    label5.Text = para.ToString();
                }
                
                }
            else if (pictureBox4.Right >= finishLine.Left)
            {
                timer1.Stop();
                MessageBox.Show("4. At kazandı!");
                if (radioButton4.Checked == true)
                {

                    para += kupon;
                    label5.Text = para.ToString();
                }
                else
                {

                    para -= kupon;
                    label5.Text = para.ToString();
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            pictureBox1.Left = 130;
            pictureBox2.Left = 130;
            pictureBox3.Left = 130;
            pictureBox4.Left = 130;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox4.Left += 30;
        }
    }
}
