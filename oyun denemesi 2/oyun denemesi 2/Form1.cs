using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun_denemesi_2
{
    public partial class Form1 : Form
    {
        int skor = 0;
        List<PictureBox> coinler = new List<PictureBox>();
        List<PictureBox> dikenler = new List<PictureBox>();
        List<PictureBox> platformlar = new List<PictureBox>();

        bool sagaBasildi = false;
        bool solaBasildi = false;
        bool yerdeMi = false;

        int hareketHizi = 7;
        int gravity = 2;
        int yerSeviyesi = 300;

        bool ziplaniyor = false;
        int ziplamaHizi = 0;
        int ziplamaGucu = -20;

        private System.Windows.Forms.Timer bekleTimer = new System.Windows.Forms.Timer();

        string sonYön = "sag";

        // Çöp kutusu
        int copTemizlikSeviye = 0;
        int copTemizlemeSiniri = 5;

        // Su ve ağaç sistemi
        int suMiktari = 0;
        int agacSulamaSeviye = 0;
        int maxSulamaSeviye = 5;

        public Form1()
        {
            InitializeComponent();

            // Platform, diken ve coinleri toplama
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is PictureBox pb && pb.Tag != null)
                {
                    if (pb.Tag.ToString() == "platform") platformlar.Add(pb);
                    else if (pb.Tag.ToString() == "diken") dikenler.Add(pb);
                    else if (pb.Tag.ToString() == "coin") coinler.Add(pb);
                }
            }

            // Etkileşim olayları
            copKutusu.Click += CopKutusu_Click;
            suKaynagi.Click += SuKaynagi_Click;
            agac.Click += Agac_Click;

            bekleTimer.Interval = 1000;
            bekleTimer.Tick += bekleTimer_Tick;
        }

        private async void KarakteriOldur()
        {
            sagaBasildi = false;
            solaBasildi = false;

            myhero.Image = Image.FromFile("hero_death.png");
            await Task.Delay(1000);

            myhero.Top = 81;
            myhero.Left = 50;
            ziplamaHizi = 0;
            ziplaniyor = false;
            sonYön = "sag";
            myhero.Image = Image.FromFile("hero0.png");
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            // === SAĞ ===
            if (sagaBasildi)
            {
                Rectangle yeniAlan = myhero.Bounds;
                yeniAlan.X += hareketHizi;

                if (!platformlar.Any(p => yeniAlan.IntersectsWith(p.Bounds)))
                {
                    myhero.Left += hareketHizi;
                    myhero.Image = Image.FromFile("hero_run0.png");
                    sonYön = "sag";
                }
            }

            // === SOL ===
            if (solaBasildi)
            {
                Rectangle yeniAlan = myhero.Bounds;
                yeniAlan.X -= hareketHizi;

                if (!platformlar.Any(p => yeniAlan.IntersectsWith(p.Bounds)))
                {
                    myhero.Left -= hareketHizi;
                    myhero.Image = Image.FromFile("hero_run1.png");
                    sonYön = "sol";
                }
            }

            // === Zıplama ===
            if (ziplaniyor)
            {
                myhero.Image = Image.FromFile("hero_jump_0.png");
                myhero.Top += ziplamaHizi;
                ziplamaHizi += gravity;

                if (ziplamaHizi > 10)
                    ziplaniyor = false;
            }
            else if (!yerdeMi)
            {
                myhero.Top += gravity;
            }

            // === Platform çarpışması ===
            bool carpti = false;
            foreach (var platform in platformlar)
            {
                if (myhero.Bounds.IntersectsWith(platform.Bounds))
                {
                    if (myhero.Bottom >= platform.Top &&
                        myhero.Top < platform.Top &&
                        myhero.Right > platform.Left &&
                        myhero.Left < platform.Right)
                    {
                        myhero.Top = platform.Top - myhero.Height;
                        ziplaniyor = false;
                        ziplamaHizi = 0;
                        carpti = true;
                        break;
                    }
                }
            }
            yerdeMi = carpti;

            // === Diken çarpışması ===
            foreach (var diken in dikenler)
            {
                if (myhero.Bounds.IntersectsWith(diken.Bounds))
                {
                    KarakteriOldur();
                    return;
                }
            }

            // === Coin çarpışması ===
            foreach (var coin in coinler.ToList())
            {
                if (myhero.Bounds.IntersectsWith(coin.Bounds))
                {
                    skor += 10;
                    label1.Text = "Para: " + skor;
                    this.Controls.Remove(coin);
                    coinler.Remove(coin);
                    break;
                }
            }

            // === Durma animasyonu ===
            if (!sagaBasildi && !solaBasildi && yerdeMi && !ziplaniyor)
            {
                if (sonYön == "sag")
                    myhero.Image = Image.FromFile("hero0.png");
                else
                    myhero.Image = Image.FromFile("hero1.png");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) sagaBasildi = true;
            else if (e.KeyCode == Keys.Left) solaBasildi = true;

            if (e.KeyCode == Keys.Space && yerdeMi && !ziplaniyor)
            {
                ziplaniyor = true;
                ziplamaHizi = ziplamaGucu;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) sagaBasildi = false;
            else if (e.KeyCode == Keys.Left) solaBasildi = false;
        }

        private void bekleTimer_Tick(object sender, EventArgs e)
        {
            bekleTimer.Stop();
        }

        // ========================= Çöp Kutusu =========================
        private void CopKutusu_Click(object sender, EventArgs e)
        {
            int mesafe = Math.Abs(myhero.Left - copKutusu.Left);
            if (mesafe > 200)
            {
                MessageBox.Show("Çöp kutusuna yaklaşmalısın!");
                return;
            }

            if (copTemizlikSeviye < copTemizlemeSiniri)
            {
                copTemizlikSeviye++;
                copProgressBar.Value = copTemizlikSeviye * (100 / copTemizlemeSiniri);
                string resimYolu = $"cop{copTemizlikSeviye}.png";
                if (System.IO.File.Exists(resimYolu))
                    copKutusu.Image = Image.FromFile(resimYolu);

                if (copTemizlikSeviye == copTemizlemeSiniri)
                    MessageBox.Show("Çöp kutusu tamamen temizlendi! ✨");
            }
        }

        // ========================= Su Alma =========================
        private void SuKaynagi_Click(object sender, EventArgs e)
        {
            int mesafe = Math.Abs(myhero.Left - suKaynagi.Left);
            if (mesafe > 200)
            {
                MessageBox.Show("Su almak için yaklaşırsan iyi olur!");
                return;
            }

            if (suMiktari < maxSulamaSeviye)
            {
                suMiktari++;
                suProgressBar.Value = suMiktari * (100 / maxSulamaSeviye);
            }
        }

        // ========================= Ağaç Sulama =========================
        private void Agac_Click(object sender, EventArgs e)
        {
            int mesafe = Math.Abs(myhero.Left - agac.Left);
            if (mesafe > 200)
            {
                MessageBox.Show("Ağacı sulamak için daha da yaklaş!");
                return;
            }

            if (suMiktari > 0 && agacSulamaSeviye < maxSulamaSeviye)
            {
                suMiktari--;
                suProgressBar.Value = suMiktari * (100 / maxSulamaSeviye);

                agacSulamaSeviye++;
                agacProgressBar.Value = agacSulamaSeviye * (100 / maxSulamaSeviye);

                if (agacSulamaSeviye == maxSulamaSeviye)
                    MessageBox.Show("Ağaç tamamen sulandı! 🌳");
            }
            else if (suMiktari == 0)
            {
                MessageBox.Show("Önce su almanız gerekiyor!");
            }
        }
    }
}
