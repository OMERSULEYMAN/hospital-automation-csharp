namespace udemy_Hastane_Otomasyonu
{
    partial class FormHastaKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaKayit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hst_cinsiyyet_cmb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.hastasoyad_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.hst_sifre_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.hastaad_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hst_tel_txt = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hst_masked_tc = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_hasta_kaydet = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(827, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 166);
            this.panel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(342, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 54);
            this.label1.TabIndex = 30;
            this.label1.Text = "Hasta Kayıt Ekranı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(283, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 488);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.hst_cinsiyyet_cmb);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.hastasoyad_txt);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.hst_sifre_txt);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.hastaad_txt);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.hst_tel_txt);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.hst_masked_tc);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btn_hasta_kaydet);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(487, 482);
            this.panel3.TabIndex = 32;
            // 
            // hst_cinsiyyet_cmb
            // 
            this.hst_cinsiyyet_cmb.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hst_cinsiyyet_cmb.FormattingEnabled = true;
            this.hst_cinsiyyet_cmb.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.hst_cinsiyyet_cmb.Location = new System.Drawing.Point(255, 150);
            this.hst_cinsiyyet_cmb.Name = "hst_cinsiyyet_cmb";
            this.hst_cinsiyyet_cmb.Size = new System.Drawing.Size(221, 43);
            this.hst_cinsiyyet_cmb.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(4, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 42);
            this.label12.TabIndex = 32;
            this.label12.Text = "Ad :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // hastasoyad_txt
            // 
            this.hastasoyad_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastasoyad_txt.Location = new System.Drawing.Point(255, 80);
            this.hastasoyad_txt.Name = "hastasoyad_txt";
            this.hastasoyad_txt.Size = new System.Drawing.Size(221, 42);
            this.hastasoyad_txt.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(4, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 42);
            this.label11.TabIndex = 33;
            this.label11.Text = "Soyad :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // hst_sifre_txt
            // 
            this.hst_sifre_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hst_sifre_txt.Location = new System.Drawing.Point(255, 360);
            this.hst_sifre_txt.Name = "hst_sifre_txt";
            this.hst_sifre_txt.Size = new System.Drawing.Size(221, 42);
            this.hst_sifre_txt.TabIndex = 6;
            this.hst_sifre_txt.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(4, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 42);
            this.label10.TabIndex = 34;
            this.label10.Text = "  TC kimlik no : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // hastaad_txt
            // 
            this.hastaad_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaad_txt.Location = new System.Drawing.Point(255, 10);
            this.hastaad_txt.Name = "hastaad_txt";
            this.hastaad_txt.Size = new System.Drawing.Size(221, 42);
            this.hastaad_txt.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(4, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 42);
            this.label9.TabIndex = 35;
            this.label9.Text = "Telefon no :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // hst_tel_txt
            // 
            this.hst_tel_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hst_tel_txt.Location = new System.Drawing.Point(255, 290);
            this.hst_tel_txt.Mask = "(999) 000-0000";
            this.hst_tel_txt.Name = "hst_tel_txt";
            this.hst_tel_txt.Size = new System.Drawing.Size(221, 42);
            this.hst_tel_txt.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(4, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 42);
            this.label8.TabIndex = 36;
            this.label8.Text = "Cinsiyyet :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // hst_masked_tc
            // 
            this.hst_masked_tc.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hst_masked_tc.Location = new System.Drawing.Point(255, 220);
            this.hst_masked_tc.Mask = "00000000000";
            this.hst_masked_tc.Name = "hst_masked_tc";
            this.hst_masked_tc.Size = new System.Drawing.Size(221, 42);
            this.hst_masked_tc.TabIndex = 4;
            this.hst_masked_tc.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(4, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 42);
            this.label7.TabIndex = 37;
            this.label7.Text = "Şifre :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_hasta_kaydet
            // 
            this.btn_hasta_kaydet.BackColor = System.Drawing.Color.Lime;
            this.btn_hasta_kaydet.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hasta_kaydet.Location = new System.Drawing.Point(285, 426);
            this.btn_hasta_kaydet.Name = "btn_hasta_kaydet";
            this.btn_hasta_kaydet.Size = new System.Drawing.Size(166, 49);
            this.btn_hasta_kaydet.TabIndex = 38;
            this.btn_hasta_kaydet.Text = "Kayıt ol";
            this.btn_hasta_kaydet.UseVisualStyleBackColor = false;
            this.btn_hasta_kaydet.Click += new System.EventHandler(this.btn_hasta_kaydet_Click);
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Red;
            this.btngeri.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.ForeColor = System.Drawing.Color.White;
            this.btngeri.Location = new System.Drawing.Point(0, 0);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(107, 37);
            this.btngeri.TabIndex = 10;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // FormHastaKayit
            // 
            this.AcceptButton = this.btn_hasta_kaydet;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 653);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormHastaKayit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHastaKayit_FormClosing);
            this.Load += new System.EventHandler(this.Form_hasta_kayit_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox hst_cinsiyyet_cmb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox hastasoyad_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox hst_sifre_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox hastaad_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox hst_tel_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox hst_masked_tc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_hasta_kaydet;
        private System.Windows.Forms.Button btngeri;
    }
}