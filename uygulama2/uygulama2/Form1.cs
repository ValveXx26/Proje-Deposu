using System.Windows.Forms;

namespace uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
        private void button12_MouseMove(object sender, EventArgs e)
        {
            label2.Text = ("Mouse Üzerimde");
        }
        private void button12_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = ("Mouse Üzerimde deðil");
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = ("Mouse Üzerimde");
            this.ForeColor = Color.Red;
            this.BackColor = Color.Green;
        }

        private void button12_MouseLeave_1(object sender, EventArgs e)
        {
            label2.Text = ("Mouse Üzerimde deðil");
            this.ForeColor = Color.Green;
            this.BackColor = Color.Red;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox3.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool secim;
            secim = checkBox1.Checked;
            label2.Text = secim.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            int sayý1, sayý2, toplam;
            sayý1 = Convert.ToInt16(textBox2.Text);
            sayý2 = Convert.ToInt16(textBox3.Text);
            toplam = sayý1 + sayý2;
            label4.Text = toplam.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            int sayý1, sayý2, toplam;
            sayý1 = Convert.ToInt16(textBox4.Text);

            toplam = sayý1 * sayý1;
            textBox4.Text = toplam.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int sayý1, sayý2, toplam;
            sayý1 = 5;
            sayý2 = 20;
            toplam = sayý1 + sayý2;
            MessageBox.Show(toplam.ToString());
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(textBox5.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.10;
            label9.Text = indirimliFiyat.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(textBox5.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.25;
            label9.Text = indirimliFiyat.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(textBox5.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.50;
            label9.Text = indirimliFiyat.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(textBox5.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.75; //Yüzde 75 indirim
            label9.Text = indirimliFiyat.ToString();
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //textBox1.Text = "Hala genç ve güzelsiniz";
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //MessageBox.Show("Kaydetmek ister misiniz","mesaj baþlýðý",MessageBoxButtons.OKCancel); 
        //}
    }
}
