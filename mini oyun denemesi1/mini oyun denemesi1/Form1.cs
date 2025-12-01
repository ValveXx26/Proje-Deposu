using System.Diagnostics.Eventing.Reader;

namespace mini_oyun_denemesi1
{

    public partial class Form1 : Form
    {
        int cevap;
        int a, b, c, d;






        public Form1()
        {

            InitializeComponent();
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            button6.Visible = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void cevapdogru()
        {
            string dogru;
            dogru = "DOÐRU";
            label1.Text = dogru;
        }

        private void cevapyanlýs()
        {
            string yanlýs;
            yanlýs = "YANLIÞ";
            label1.Text = yanlýs;
        }
        private void cevapkontrol()

        {


            if (a == 1)
            {
                cevap = 1;
            }
            else if (b == 1)
            {
                cevap = 1;
            }
            else if (c == 1)
            {
                cevap = 1;
            }
            else
            {
                cevap = 0;
            }
            a = 0;
            b = 0;
            c = 0;
            d = 0;
        }
        private void cevapkontrol2()
        {
            if (cevap == 1) ;
            {
                cevapdogru();
            }
            if (cevap == 0)
            {
                cevapyanlýs();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            cevap = 0;
            if (radioButton1.Checked == true)
            {
                a = 0;
            }
            else if (radioButton2.Checked == true)
            {
                a = 0;
            }
            else if (radioButton3.Checked == true)
            {
                a = 1;
            }
            cevapkontrol();
            cevapkontrol2();
            a = 0;

        }

        public void button2_Click(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            button1.Visible = false;
            button6.Visible = true;
            cevap = 0;
            a = 0;
            b = 0;
            if (radioButton1.Checked == true)
            {
                b = 0;
            }
            else if (radioButton2.Checked == true)
            {
                b = 1;
            }
            else if (radioButton3.Checked == true)
            {
                b = 0;
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            cevap = 0;
            if (radioButton1.Checked == true)
            {
                a = 0;
            }
            else if (radioButton2.Checked == true)
            {
                a = 1;
            }
            else if (radioButton3.Checked == true)
            {
                a = 0;
            }
            cevapkontrol();
            cevapkontrol2();
            a = 0;
        }
    }
}
