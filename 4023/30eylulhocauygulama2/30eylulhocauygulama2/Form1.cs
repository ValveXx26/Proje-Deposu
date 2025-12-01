namespace _30eylulhocauygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "AMP10B";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
                this.Hide();
        }
    }
}
