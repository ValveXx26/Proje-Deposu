namespace otuzeyluluygulamalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte skor1, skor2;
            skor1 = 4;
            skor2 = 1;
            if (skor1 > skor2)
            {
                MessageBox.Show("1. Takým kazandý");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte yas;
            yas = Convert.ToByte(textBox1.Text);
            if (yas > 17)
            {
                MessageBox.Show("Ehliyet baþvurusunda bulunabilirsiniz");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte sayi1, sayi2;
            sayi1 = Convert.ToByte(textBox3.Text);
            sayi2 = Convert.ToByte(textBox4.Text);
            if (sayi1 > sayi2)
            {
                MessageBox.Show("1.sayý 2.sayýdan büyük");

            }
            if (sayi1 == sayi2)
            {
                MessageBox.Show("Sayýlar Birbirine Eþit");
            }
            if (sayi1 < sayi2)
            {
                MessageBox.Show("2.sayý 1.sayýdan büyüktür");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox5.Text);
            if (sayi % 2 == 0)
            {
                MessageBox.Show("Bu bir çift sayýdýr");

            }
            if (sayi % 2 == 1)
            {
                MessageBox.Show("Bu bir tek sayýdýr");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ka;
            ka = textBox6.Text;
            if (ka == "me")
            {
                MessageBox.Show("Kullanýcý sisteme kayýtlý");

            }
            else
            {
                MessageBox.Show("Kuulanýcý sisteme kayýtlý deðil");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add("Lamba Açýk");

            }
            else
            {
                listBox1.Items.Add("Lamba Kapalý");

            }
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add("Kombi Açýk");

            }
            else
            {
                listBox1.Items.Add("Kombi Kapalý");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int deger1 = Convert.ToInt32(textBox7.Text);
            int deger2 = Convert.ToInt32(textBox8.Text);
            int sonuc;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int deger1 = Convert.ToInt32(textBox7.Text);
            int deger2 = Convert.ToInt32(textBox8.Text);
            int sonuc;
            if (radioButton1.Checked == true)
            {
                label8.Text = (deger1 + deger2).ToString();
            }
            else
            {
                label8.Text = (deger2 * deger1).ToString();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox9.Text);
            if (sayi < 0)
            {
                MessageBox.Show("0' dan büyük bir sayý giriniz");
            }
            else if (sayi < 25)
            {
                MessageBox.Show("Notunuz 0");
            }
            else if (sayi < 45)
            {
                MessageBox.Show("Notunuz 1");
            }
            else if (sayi < 55)
            {
                MessageBox.Show("Notunuz 2");
            }
            else if (sayi < 70)
            {
                MessageBox.Show("Notunuz 3");
            }
            else if (sayi < 85)
            {
                MessageBox.Show("Notunuz 4");
            }
            else if (sayi <= 100)
            {
                MessageBox.Show("Notunuz 5");
            }
            else
            {
                MessageBox.Show("Yanlýþ giriþ yaptýnýz");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            byte ortalama;
            ortalama = Convert.ToByte(textBox10.Text);
            if (ortalama >=50)
            {
                if (ortalama>=85)
                {
                    label11.Text = "Taktir almaya hak kazandýnýz";
                }
                else if (ortalama >=70)
                {
                    label11.Text = "Teþekkür almaya hak kazandýnýz";

                }
                else
                {
                    label11.Text = "Belge almadan sýnýfý geçtiniz";
                }
            }
            else
            {
                label11.Text = "Üzgünüm sýnýfta kaldýnýz";
            }
        }
    }
}
