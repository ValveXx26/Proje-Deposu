namespace _31eylulhocaornekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad1, ad2, tum, cins;
            cins = "Sayýn";
            if (checkBox1.Checked == true)
            {
                cins = "Bay";
            }
            else if (checkBox2.Checked == true)
            { cins = "Bayan"; }


            ad1 = Convert.ToString(textBox1.Text);
            ad2 = Convert.ToString(textBox2.Text);
            tum = cins + " " + ad1 + " " + ad2;
            label5.Text = tum;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 x= new Form2();
            x.Show();
        }
    }
}
