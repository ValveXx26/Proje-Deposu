namespace oyun_denemesi_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            myhero = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox8 = new PictureBox();
            label1 = new Label();
            pictureBox12 = new PictureBox();
            copKutusu = new PictureBox();
            copProgressBar = new ProgressBar();
            suKaynagi = new PictureBox();
            agac = new PictureBox();
            suProgressBar = new ProgressBar();
            agacProgressBar = new ProgressBar();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)myhero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)copKutusu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)suKaynagi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agac).BeginInit();
            SuspendLayout();
            // 
            // myhero
            // 
            myhero.Image = Properties.Resources.character_idle_1_1;
            myhero.Location = new Point(75, 364);
            myhero.Name = "myhero";
            myhero.Size = new Size(126, 158);
            myhero.SizeMode = PictureBoxSizeMode.Zoom;
            myhero.TabIndex = 3;
            myhero.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.duzuzun;
            pictureBox4.Location = new Point(17, 517);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(502, 260);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "platform";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.duzuzun;
            pictureBox5.Location = new Point(493, 517);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(501, 260);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "platform";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.duzuzun;
            pictureBox6.Location = new Point(963, 517);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(601, 260);
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "platform";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.diken;
            pictureBox8.Location = new Point(1260, 402);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(145, 47);
            pictureBox8.TabIndex = 11;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "diken";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 24);
            label1.TabIndex = 13;
            label1.Text = "Para:";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.coin1;
            pictureBox12.Location = new Point(1078, 379);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(53, 70);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 16;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "coin";
            // 
            // copKutusu
            // 
            copKutusu.Image = (Image)resources.GetObject("copKutusu.Image");
            copKutusu.Location = new Point(786, 412);
            copKutusu.Name = "copKutusu";
            copKutusu.Size = new Size(100, 110);
            copKutusu.SizeMode = PictureBoxSizeMode.Zoom;
            copKutusu.TabIndex = 17;
            copKutusu.TabStop = false;
            copKutusu.Tag = "cop";
            // 
            // copProgressBar
            // 
            copProgressBar.Location = new Point(786, 341);
            copProgressBar.Name = "copProgressBar";
            copProgressBar.Size = new Size(100, 23);
            copProgressBar.TabIndex = 18;
            // 
            // suKaynagi
            // 
            suKaynagi.Image = Properties.Resources.suKaynagı;
            suKaynagi.Location = new Point(619, 379);
            suKaynagi.Name = "suKaynagi";
            suKaynagi.Size = new Size(100, 143);
            suKaynagi.SizeMode = PictureBoxSizeMode.Zoom;
            suKaynagi.TabIndex = 19;
            suKaynagi.TabStop = false;
            // 
            // agac
            // 
            agac.Image = Properties.Resources.agac;
            agac.Location = new Point(328, 312);
            agac.Name = "agac";
            agac.Size = new Size(144, 210);
            agac.SizeMode = PictureBoxSizeMode.Zoom;
            agac.TabIndex = 20;
            agac.TabStop = false;
            // 
            // suProgressBar
            // 
            suProgressBar.Location = new Point(73, 51);
            suProgressBar.Name = "suProgressBar";
            suProgressBar.Size = new Size(100, 23);
            suProgressBar.TabIndex = 21;
            // 
            // agacProgressBar
            // 
            agacProgressBar.Location = new Point(349, 283);
            agacProgressBar.Name = "agacProgressBar";
            agacProgressBar.Size = new Size(100, 23);
            agacProgressBar.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(55, 24);
            label2.TabIndex = 23;
            label2.Text = "Su =";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1468, 825);
            Controls.Add(myhero);
            Controls.Add(label2);
            Controls.Add(suProgressBar);
            Controls.Add(pictureBox12);
            Controls.Add(label1);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(agac);
            Controls.Add(suKaynagi);
            Controls.Add(copKutusu);
            Controls.Add(copProgressBar);
            Controls.Add(agacProgressBar);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)myhero).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)copKutusu).EndInit();
            ((System.ComponentModel.ISupportInitialize)suKaynagi).EndInit();
            ((System.ComponentModel.ISupportInitialize)agac).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox myhero;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private Label label1;
        private PictureBox pictureBox12;
        private PictureBox copKutusu;
        private ProgressBar copProgressBar;
        private PictureBox suKaynagi;
        private PictureBox agac;
        private ProgressBar suProgressBar;
        private ProgressBar agacProgressBar;
        private Label label2;
    }
}
