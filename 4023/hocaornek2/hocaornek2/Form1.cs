namespace hocaornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (!int.TryParse(textBox1.Text, out int sayi1) || !int.TryParse(textBox2.Text, out int sayi2))
            {
                MessageBox.Show("Lütfen geçerli iki sayý girin.");
                return;
            }

            double sonuc = 0;
            bool iþlemYapýldý = true;

            if (radioButton1.Checked)
            {
                sonuc = sayi1 + sayi2;
            }
            else if (radioButton2.Checked)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (radioButton3.Checked)
            {
                sonuc = sayi1 * sayi2;
            }
            else if (radioButton4.Checked)
            {
                if (sayi2 == 0)
                {
                    MessageBox.Show("0'a bölme hatasý!");
                    return;
                }
                sonuc = (double)sayi1 / sayi2;
            }
            else if (radioButton5.Checked)
            {
                if (sayi2 == 0)
                {
                    MessageBox.Show("0'a göre mod alýnamaz!");
                    return;
                }
                sonuc = sayi1 % sayi2;
            }
            else
            {
                iþlemYapýldý = false;
                MessageBox.Show("Lütfen bir iþlem seçin.");
            }

            if (iþlemYapýldý)
            {
                textBox3.Text = sonuc.ToString();
            }
        }
    }
}
