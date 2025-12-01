namespace at_yarışı_deneme_1
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            finishLine = new PictureBox();
            radioButton4 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)finishLine).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.horse_race_clipart_lg;
            pictureBox1.Location = new Point(149, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.horse_race_clipart_lg;
            pictureBox2.Location = new Point(149, 254);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.horse_race_clipart_lg;
            pictureBox3.Location = new Point(149, 402);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 82);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 176);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 3;
            label1.Text = "1 numaralı at";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 284);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 4;
            label2.Text = "2 numaralı at";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 429);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 5;
            label3.Text = "3 numaralı at";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(474, 21);
            button1.Name = "button1";
            button1.Size = new Size(138, 44);
            button1.TabIndex = 7;
            button1.Text = "YARIŞI BAŞLAT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(680, 21);
            button2.Name = "button2";
            button2.Size = new Size(138, 44);
            button2.TabIndex = 8;
            button2.Text = "RESTART";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(16, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(117, 161);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hangisi Kazanır";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = Color.Yellow;
            radioButton3.Location = new Point(17, 92);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(64, 25);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "3. At";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.Yellow;
            radioButton2.Location = new Point(17, 57);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(64, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "2. At";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.Yellow;
            radioButton1.Location = new Point(17, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(64, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "1. At";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(166, 21);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 10;
            label4.Text = "PARA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(226, 21);
            label5.Name = "label5";
            label5.Size = new Size(19, 21);
            label5.TabIndex = 11;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(16, 551);
            label6.Name = "label6";
            label6.Size = new Size(126, 25);
            label6.TabIndex = 12;
            label6.Text = "4 numaralı at";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.horse_race_clipart_lg;
            pictureBox4.Location = new Point(148, 527);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(101, 82);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            pictureBox4.MouseClick += pictureBox4_MouseClick;
            // 
            // finishLine
            // 
            finishLine.Image = Properties.Resources.finish;
            finishLine.Location = new Point(933, -34);
            finishLine.Name = "finishLine";
            finishLine.Size = new Size(340, 739);
            finishLine.SizeMode = PictureBoxSizeMode.Zoom;
            finishLine.TabIndex = 14;
            finishLine.TabStop = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton4.ForeColor = Color.Yellow;
            radioButton4.Location = new Point(17, 123);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(64, 25);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "4. At";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(1272, 672);
            Controls.Add(finishLine);
            Controls.Add(pictureBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)finishLine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox4;
        private PictureBox finishLine;
        private RadioButton radioButton4;
    }
}
