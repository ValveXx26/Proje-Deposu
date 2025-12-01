using System.Diagnostics.Eventing.Reader;

namespace _7ekimuygulamalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte s;
            s = Convert.ToByte(comboBox1.SelectedIndex);
            if (s > 0 && s < 5)
            {
                MessageBox.Show("Ýlkokul kademesi");

            }
            else if (s > 4 && s < 9)
            {
                MessageBox.Show("Ortaokul Kademesi");

            }
            else if (s > 8 && s < 13)

            {
                MessageBox.Show("Lise Kademesi");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t;
            t = Convert.ToDouble(textBox1.Text);
            if (radioButton2.Checked == true)
            {
                t = t + (t * 0.05);

            }
            if (radioButton3.Checked == true)
            {
                t = t + (t * 0.10);
            }
            MessageBox.Show("Ödenevek Toplam Tutar:" + t.ToString() + "TL");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s;
            s = listBox1.SelectedItem.ToString();
            if (s == "Mouse" || s == "Klavye" || s == "Kamera" || s == "Tarayýcý")
            {
                MessageBox.Show("Bu parça GÝRÝÞ birimidir");

            }
            if (s == "Yazýcý" || s == "Hoparlör" || s == "Projeksiyon")
            {
                MessageBox.Show("Bu parça ÇIKIÞ birimidir");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int g = Convert.ToInt32(DateTime.Now.DayOfWeek);
            switch (g)
            {
                case 0:
                    MessageBox.Show("Pazar");
                    break;
                case 1:
                    MessageBox.Show("Pazartesi");
                    break;
                case 2:
                    MessageBox.Show("Salý");
                    break;
                case 3:
                    MessageBox.Show("Çar");
                    break;
                case 4:
                    MessageBox.Show("Per");
                    break;
                case 5:
                    MessageBox.Show("cum");
                    break;
                case 6:
                    MessageBox.Show("cumar");
                    break;

            }
        }
    }
}
