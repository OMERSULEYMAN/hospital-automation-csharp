namespace udemy_Hastane_Otomasyonu
{
    partial class FormDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktorGiris));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.doktor_sifre = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.doktor_tc = new System.Windows.Forms.TextBox();
            this.btn_doktor_giris = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btngeri = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(288, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 352);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btn_doktor_giris);
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
            this.panel6.Controls.Add(this.doktor_sifre);
            this.panel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Location = new System.Drawing.Point(197, 172);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(213, 31);
            this.panel6.TabIndex = 8;
            // 
            // doktor_sifre
            // 
            this.doktor_sifre.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doktor_sifre.Location = new System.Drawing.Point(1, 1);
            this.doktor_sifre.Name = "doktor_sifre";
            this.doktor_sifre.Size = new System.Drawing.Size(211, 34);
            this.doktor_sifre.TabIndex = 3;
            this.doktor_sifre.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.doktor_tc);
            this.panel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(196, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 31);
            this.panel4.TabIndex = 6;
            // 
            // doktor_tc
            // 
            this.doktor_tc.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doktor_tc.Location = new System.Drawing.Point(1, 1);
            this.doktor_tc.Name = "doktor_tc";
            this.doktor_tc.Size = new System.Drawing.Size(211, 34);
            this.doktor_tc.TabIndex = 3;
            // 
            // btn_doktor_giris
            // 
            this.btn_doktor_giris.BackColor = System.Drawing.Color.Lime;
            this.btn_doktor_giris.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_doktor_giris.Location = new System.Drawing.Point(196, 233);
            this.btn_doktor_giris.Name = "btn_doktor_giris";
            this.btn_doktor_giris.Size = new System.Drawing.Size(214, 37);
            this.btn_doktor_giris.TabIndex = 5;
            this.btn_doktor_giris.Text = "GİRİŞ YAP";
            this.btn_doktor_giris.UseVisualStyleBackColor = false;
            this.btn_doktor_giris.Click += new System.EventHandler(this.btn_doktor_giris_Click);
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
            this.label3.Size = new System.Drawing.Size(247, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doktor Girişi";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(827, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 166);
            this.panel1.TabIndex = 7;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Red;
            this.btngeri.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.ForeColor = System.Drawing.Color.White;
            this.btngeri.Location = new System.Drawing.Point(0, 0);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(107, 37);
            this.btngeri.TabIndex = 9;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // FormDoktorGiris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 653);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.Name = "FormDoktorGiris";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Giriş Sayfası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDoktorGiris_FormClosing);
            this.Load += new System.EventHandler(this.FormDoktorGiris_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox doktor_sifre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox doktor_tc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_doktor_giris;
        private System.Windows.Forms.Button btngeri;
    }
}