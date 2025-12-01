namespace _30_eylul_hoca_uygulama_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Form Sýnýf uygulama2";
            this.BackColor = Color.Green;
            this.ForeColor = Color.Red;
            this.Size = new(300, 150);

            label1.Text = "Adýnýz";
            label1.Location = new Point(10, 10);
            label1.ForeColor = Color.DarkRed;
            label1.Size = new Size(65, 15);

            textBox1.Location = new Point(75, 10);
            textBox1.Size = new Size(150, 15);
            textBox1.TabIndex = 1;

            button1.Text = "Týkla";
            button1.Location = new Point(100, 60);
            button1.Size = new Size(100, 30);
            button1.ForeColor = Color.Red;
            button1.BackColor = Color.White;
            button1.TabIndex = 2;

            textBox1.KeyPress += textBox1_KeyPress;

            this.Controls.Add(label1);
            this.Controls.Add(textBox1);
            this.Controls.Add(button1);

        }


        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form1 click çalýþýyor");
        }

        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba " + textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
