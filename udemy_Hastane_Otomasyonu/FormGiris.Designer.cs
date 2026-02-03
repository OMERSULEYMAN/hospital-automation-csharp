namespace udemy_Hastane_Otomasyonu
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.hasta_sifre = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.hasta_tc = new System.Windows.Forms.TextBox();
            this.uye_link_lbl = new System.Windows.Forms.LinkLabel();
            this.btn_hasta_giris = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_doktor_giris = new System.Windows.Forms.Button();
            this.btn_sekreter_giris = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(827, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 166);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.linkLabel1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(191, 603);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(827, 41);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Soru ve sorunlarınız için xxxxx@xxxxx.com adresimizi kullanarak bize ulaş" +
    "abilirsiniz.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.uye_link_lbl);
            this.panel2.Controls.Add(this.btn_hasta_giris);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 346);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Controls.Add(this.hasta_sifre);
            this.panel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Location = new System.Drawing.Point(197, 172);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(213, 31);
            this.panel6.TabIndex = 8;
            // 
            // hasta_sifre
            // 
            this.hasta_sifre.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta_sifre.Location = new System.Drawing.Point(1, 1);
            this.hasta_sifre.Name = "hasta_sifre";
            this.hasta_sifre.Size = new System.Drawing.Size(211, 34);
            this.hasta_sifre.TabIndex = 3;
            this.hasta_sifre.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.hasta_tc);
            this.panel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(196, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 31);
            this.panel4.TabIndex = 6;
            // 
            // hasta_tc
            // 
            this.hasta_tc.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta_tc.Location = new System.Drawing.Point(1, 1);
            this.hasta_tc.Name = "hasta_tc";
            this.hasta_tc.Size = new System.Drawing.Size(211, 34);
            this.hasta_tc.TabIndex = 3;
            this.hasta_tc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // uye_link_lbl
            // 
            this.uye_link_lbl.ActiveLinkColor = System.Drawing.Color.Red;
            this.uye_link_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uye_link_lbl.Location = new System.Drawing.Point(251, 288);
            this.uye_link_lbl.Name = "uye_link_lbl";
            this.uye_link_lbl.Size = new System.Drawing.Size(159, 35);
            this.uye_link_lbl.TabIndex = 6;
            this.uye_link_lbl.TabStop = true;
            this.uye_link_lbl.Text = "Hesap Oluştur";
            this.uye_link_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uye_link_lbl_LinkClicked);
            // 
            // btn_hasta_giris
            // 
            this.btn_hasta_giris.BackColor = System.Drawing.Color.Lime;
            this.btn_hasta_giris.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hasta_giris.Location = new System.Drawing.Point(196, 233);
            this.btn_hasta_giris.Name = "btn_hasta_giris";
            this.btn_hasta_giris.Size = new System.Drawing.Size(214, 37);
            this.btn_hasta_giris.TabIndex = 5;
            this.btn_hasta_giris.Text = "GİRİŞ YAP";
            this.btn_hasta_giris.UseVisualStyleBackColor = false;
            this.btn_hasta_giris.Click += new System.EventHandler(this.btn_hasta_giris_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 49);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sifre :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "TC kimlik no :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hasta Girişi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(363, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "xxxx Hastanesi ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(349, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 58);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yönetim Sistemi ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(298, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 352);
            this.panel3.TabIndex = 5;
            // 
            // btn_doktor_giris
            // 
            this.btn_doktor_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_doktor_giris.BackgroundImage")));
            this.btn_doktor_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doktor_giris.Location = new System.Drawing.Point(8, 450);
            this.btn_doktor_giris.Name = "btn_doktor_giris";
            this.btn_doktor_giris.Size = new System.Drawing.Size(92, 54);
            this.btn_doktor_giris.TabIndex = 6;
            this.btn_doktor_giris.UseVisualStyleBackColor = true;
            this.btn_doktor_giris.Click += new System.EventHandler(this.btn_doktor_giris_Click);
            // 
            // btn_sekreter_giris
            // 
            this.btn_sekreter_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sekreter_giris.BackgroundImage")));
            this.btn_sekreter_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sekreter_giris.Location = new System.Drawing.Point(8, 525);
            this.btn_sekreter_giris.Name = "btn_sekreter_giris";
            this.btn_sekreter_giris.Size = new System.Drawing.Size(92, 54);
            this.btn_sekreter_giris.TabIndex = 7;
            this.btn_sekreter_giris.UseVisualStyleBackColor = true;
            this.btn_sekreter_giris.Click += new System.EventHandler(this.btn_sekreter_giris_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doktor Girişi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 575);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sekreter Girişi";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 166);
            this.panel5.TabIndex = 10;
            // 
            // FormGiris
            // 
            this.AcceptButton = this.btn_hasta_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 653);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_sekreter_giris);
            this.Controls.Add(this.btn_doktor_giris);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Giriş Ekranımıza Hoş Geldiniz!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGiris_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hasta_tc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_hasta_giris;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel uye_link_lbl;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox hasta_sifre;
        private System.Windows.Forms.Button btn_doktor_giris;
        private System.Windows.Forms.Button btn_sekreter_giris;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
    }
}

