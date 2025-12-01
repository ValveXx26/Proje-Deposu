namespace uygulama_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkceDogru, matDogru;
            double turkceYanlis, matYanlis;
            double turkceNet, matNet;
            turkceDogru = Convert.ToDouble(textBox4.Text);
            turkceYanlis = Convert.ToDouble(textBox6.Text);
            turkceNet = (turkceDogru - (turkceYanlis / 4));
            textBox5.Text = turkceNet.ToString();
            matDogru = Convert.ToDouble(textBox1.Text);
            matYanlis = Convert.ToDouble(textBox2.Text);
            matNet = (matDogru - (matYanlis / 4));
            textBox3.Text = matNet.ToString();
        }
    }
}
