namespace _7ekimuygulamalar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            button2 = new Button();
            listBox1 = new ListBox();
            groupBox5 = new GroupBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.IndianRed;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(50, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 75);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "U13";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox1.Location = new Point(45, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 128, 255);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(309, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 266);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "U14";
            // 
            // button1
            // 
            button1.Location = new Point(54, 231);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 3;
            button1.Text = "Ödeme yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(18, 62);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(170, 163);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ödeme Şekli";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(24, 97);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(47, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "%10";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(24, 72);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "%5";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(24, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(42, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tek";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 36);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Toplam Tutar";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(listBox1);
            groupBox4.Location = new Point(567, 37);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(212, 278);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "U15";
            // 
            // button2
            // 
            button2.Location = new Point(41, 225);
            button2.Name = "button2";
            button2.Size = new Size(120, 41);
            button2.TabIndex = 1;
            button2.Text = "Kontrol et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Mouse", "Yazıcı", "Klavye", "Hoparlör", "Kamera", "Tarayıcı", "Projeksiyon" });
            listBox1.Location = new Point(41, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 169);
            listBox1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(button3);
            groupBox5.Location = new Point(39, 146);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(246, 181);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // button3
            // 
            button3.Location = new Point(68, 54);
            button3.Name = "button3";
            button3.Size = new Size(109, 74);
            button3.TabIndex = 0;
            button3.Text = "Bu günü öğren";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1478, 839);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private Button button1;
        private GroupBox groupBox3;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox4;
        private Button button2;
        private ListBox listBox1;
        private GroupBox groupBox5;
        private Button button3;
    }
}
