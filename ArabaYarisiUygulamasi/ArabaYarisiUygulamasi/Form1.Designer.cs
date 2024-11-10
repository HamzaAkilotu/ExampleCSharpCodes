namespace ArabaYarisiUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_carpma = new System.Windows.Forms.PictureBox();
            this.araba2 = new System.Windows.Forms.PictureBox();
            this.araba1 = new System.Windows.Forms.PictureBox();
            this.arabam = new System.Windows.Forms.PictureBox();
            this.yol = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_puan = new System.Windows.Forms.Label();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.sayac = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_yuksekSkor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_carpma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox_carpma);
            this.panel1.Controls.Add(this.araba2);
            this.panel1.Controls.Add(this.araba1);
            this.panel1.Controls.Add(this.arabam);
            this.panel1.Controls.Add(this.yol);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 523);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox_carpma
            // 
            this.pictureBox_carpma.Image = global::ArabaYarisiUygulamasi.Properties.Resources.explosion;
            this.pictureBox_carpma.Location = new System.Drawing.Point(291, 325);
            this.pictureBox_carpma.Name = "pictureBox_carpma";
            this.pictureBox_carpma.Size = new System.Drawing.Size(77, 46);
            this.pictureBox_carpma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_carpma.TabIndex = 2;
            this.pictureBox_carpma.TabStop = false;
            // 
            // araba2
            // 
            this.araba2.Image = global::ArabaYarisiUygulamasi.Properties.Resources.araba6;
            this.araba2.Location = new System.Drawing.Point(338, 61);
            this.araba2.Name = "araba2";
            this.araba2.Size = new System.Drawing.Size(81, 172);
            this.araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba2.TabIndex = 1;
            this.araba2.TabStop = false;
            // 
            // araba1
            // 
            this.araba1.Image = global::ArabaYarisiUygulamasi.Properties.Resources.araba8;
            this.araba1.Location = new System.Drawing.Point(118, 61);
            this.araba1.Name = "araba1";
            this.araba1.Size = new System.Drawing.Size(69, 134);
            this.araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba1.TabIndex = 1;
            this.araba1.TabStop = false;
            // 
            // arabam
            // 
            this.arabam.Image = global::ArabaYarisiUygulamasi.Properties.Resources.araba4;
            this.arabam.Location = new System.Drawing.Point(229, 357);
            this.arabam.Name = "arabam";
            this.arabam.Size = new System.Drawing.Size(69, 134);
            this.arabam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arabam.TabIndex = 1;
            this.arabam.TabStop = false;
            // 
            // yol
            // 
            this.yol.Image = global::ArabaYarisiUygulamasi.Properties.Resources.yol;
            this.yol.Location = new System.Drawing.Point(0, -252);
            this.yol.Name = "yol";
            this.yol.Size = new System.Drawing.Size(518, 775);
            this.yol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol.TabIndex = 1;
            this.yol.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(416, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "PUAN :";
            // 
            // lbl_puan
            // 
            this.lbl_puan.AutoSize = true;
            this.lbl_puan.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_puan.Location = new System.Drawing.Point(496, 553);
            this.lbl_puan.Name = "lbl_puan";
            this.lbl_puan.Size = new System.Drawing.Size(21, 22);
            this.lbl_puan.TabIndex = 1;
            this.lbl_puan.Text = "0";
            // 
            // btn_baslat
            // 
            this.btn_baslat.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baslat.Location = new System.Drawing.Point(12, 608);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(518, 45);
            this.btn_baslat.TabIndex = 2;
            this.btn_baslat.Text = "Oyunu Başlat";
            this.btn_baslat.UseVisualStyleBackColor = true;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // sayac
            // 
            this.sayac.Tick += new System.EventHandler(this.sayac_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "YÜKSEK SKOR :";
            // 
            // lbl_yuksekSkor
            // 
            this.lbl_yuksekSkor.AutoSize = true;
            this.lbl_yuksekSkor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yuksekSkor.Location = new System.Drawing.Point(180, 553);
            this.lbl_yuksekSkor.Name = "lbl_yuksekSkor";
            this.lbl_yuksekSkor.Size = new System.Drawing.Size(21, 22);
            this.lbl_yuksekSkor.TabIndex = 1;
            this.lbl_yuksekSkor.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 685);
            this.Controls.Add(this.btn_baslat);
            this.Controls.Add(this.lbl_yuksekSkor);
            this.Controls.Add(this.lbl_puan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "YARIŞ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_carpma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox yol;
        private System.Windows.Forms.PictureBox araba2;
        private System.Windows.Forms.PictureBox araba1;
        private System.Windows.Forms.PictureBox arabam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_puan;
        private System.Windows.Forms.Button btn_baslat;
        private System.Windows.Forms.Timer sayac;
        public System.Windows.Forms.PictureBox pictureBox_carpma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_yuksekSkor;
    }
}

