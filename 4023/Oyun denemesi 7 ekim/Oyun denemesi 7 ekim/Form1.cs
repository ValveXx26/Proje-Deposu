namespace Oyun_denemesi_7_ekim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value - 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Top = progressBar1.Top - 4;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 40)
            {
                MessageBox.Show("KAYBETTÝNÝZ");

            }
            else
            {
                MessageBox.Show("Kazandýnýz");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 5;
        }
    }
}
