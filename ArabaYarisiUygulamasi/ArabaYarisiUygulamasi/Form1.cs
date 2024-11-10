using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ArabaYarisiUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kazanilanPuan = 0;

        int yolHizi = 25;
        int benimArabaHizi = 25;
        int digerArabaHizi = 25;

        bool solYon = false;
        bool sagYon = false;

        Random rnd = new Random();

        public void Oyunu_Baslat()
        {
            btn_baslat.Enabled = false;
            pictureBox_carpma.Visible = false;
            pictureBox_carpma.Left = 165;
            pictureBox_carpma.Top = 294;

            benimArabaHizi = 15;
            digerArabaHizi = 25;

            //Koordinatlar
            arabam.Left = 160;
            arabam.Top = 300;
            araba1.Left = 30;
            araba1.Top = 50;
            araba2.Left = 320;
            araba2.Top = 50;

            solYon = false;
            sagYon = false;

            lbl_yuksekSkor.Text = Settings1.Default.yuksekSkor.ToString();  

            sayac.Start();
        }

        private void btn_baslat_Click(object sender, EventArgs e)
        {
            Oyunu_Baslat();
        }

        private void sayac_Tick(object sender, EventArgs e)
        {
            kazanilanPuan++;
            lbl_puan.Text = kazanilanPuan.ToString();

            yol.Top += yolHizi;
            if (yol.Top > 400)
            {
                yol.Top = -100;
            }
            if (solYon)
            {
                arabam.Left -= benimArabaHizi;
            }
            if (sagYon)
            {
                arabam.Left += digerArabaHizi;
            }
            if (arabam.Left < 1)
            {
                solYon = false;
            }
            else if (arabam.Left + arabam.Width > 510)
            {
                sagYon = false;
            }
            araba1.Top += digerArabaHizi;
            araba2.Top += digerArabaHizi;
            if (araba1.Top > panel1.Height)
            {
                araba1Degistir();
                araba1.Left = rnd.Next(20, 50);
                araba1.Top = rnd.Next(40, 140) * (-1);
            }
            if (araba2.Top > panel1.Height)
            {
                araba2Degistir();
                araba2.Left = rnd.Next(20, 50);
                araba2.Top = rnd.Next(40, 140) * (-1);
            }
            if (arabam.Bounds.IntersectsWith(araba1.Bounds) || arabam.Bounds.IntersectsWith(araba2.Bounds))
            {
                oyunuBitir();
            }
        }

        private void araba1Degistir()
        {
            int sira = rnd.Next(1, 7);
            switch (sira)
            {
                case 1:
                    araba1.Image = Properties.Resources.araba1;
                    break;
                case 2:
                    araba1.Image = Properties.Resources.araba2;
                    break;
                case 3:
                    araba1.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    araba1.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    araba1.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    araba1.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    araba1.Image = Properties.Resources.araba7;
                    break;
                default:
                    break;
            }
        }

        private void araba2Degistir()
        {
            int sira = rnd.Next(1, 7);
            switch (sira)
            {
                case 1:
                    araba2.Image = Properties.Resources.araba1;
                    break;
                case 2:
                    araba2.Image = Properties.Resources.araba2;
                    break;
                case 3:
                    araba2.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    araba2.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    araba2.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    araba2.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    araba2.Image = Properties.Resources.araba7;
                    break;
                default:
                    break;
            }
        }

        private void sesAc()
        {
            SoundPlayer ses = new SoundPlayer();
            string sesYol = Application.StartupPath + "\\LVBEL-C5-DACIA.wav";
            ses.SoundLocation = sesYol;
            ses.Play();
        }

        private void oyunuBitir()
        {
            if (Convert.ToInt32(lbl_puan.Text) > Convert.ToInt32(Settings1.Default.yuksekSkor.ToString()))
            {
                Settings1.Default.yuksekSkor = lbl_puan.Text;
            }
            sayac.Stop();
            btn_baslat.Enabled = true;
            pictureBox_carpma.Visible = true;
            arabam.Controls.Add(pictureBox_carpma);
            pictureBox_carpma.Location = new Point(7, -5);
            pictureBox_carpma.BringToFront();
            pictureBox_carpma.BackColor = Color.Transparent;
            MessageBox.Show("Tebrikler! Puan : " + lbl_puan.Text, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Oyunu_Baslat();
            sesAc();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && arabam.Left > 0)
            {
                solYon = true;
            }
            if (e.KeyCode == Keys.Right && arabam.Left + arabam.Width < panel1.Width)
            {
                sagYon = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                solYon = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                sagYon = false;
            }
        }
    }
}
