namespace udemy_Hastane_Otomasyonu
{
    partial class FormSekreterDetay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlbrans = new System.Windows.Forms.Button();
            this.paneldoktor = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.pnlrandevuliste = new System.Windows.Forms.Button();
            this.sekreteradsoyadlbl = new System.Windows.Forms.Label();
            this.sekretertclbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnduyuruolustur = new System.Windows.Forms.Button();
            this.duyururichtxtbox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnrandevukaydet = new System.Windows.Forms.Button();
            this.randevudoktorcmb = new System.Windows.Forms.ComboBox();
            this.randevubranscmb = new System.Windows.Forms.ComboBox();
            this.randevusaat = new System.Windows.Forms.MaskedTextBox();
            this.randevutarih = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.pnlbrans);
            this.groupBox1.Controls.Add(this.paneldoktor);
            this.groupBox1.Controls.Add(this.exitbtn);
            this.groupBox1.Controls.Add(this.pnlrandevuliste);
            this.groupBox1.Controls.Add(this.sekreteradsoyadlbl);
            this.groupBox1.Controls.Add(this.sekretertclbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 275);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgileriniz";
            // 
            // pnlbrans
            // 
            this.pnlbrans.BackColor = System.Drawing.Color.White;
            this.pnlbrans.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlbrans.Location = new System.Drawing.Point(5, 224);
            this.pnlbrans.Name = "pnlbrans";
            this.pnlbrans.Size = new System.Drawing.Size(155, 40);
            this.pnlbrans.TabIndex = 9;
            this.pnlbrans.Text = "Branş Paneli";
            this.pnlbrans.UseVisualStyleBackColor = false;
            this.pnlbrans.Click += new System.EventHandler(this.pnlbrans_Click);
            // 
            // paneldoktor
            // 
            this.paneldoktor.BackColor = System.Drawing.Color.White;
            this.paneldoktor.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paneldoktor.ForeColor = System.Drawing.Color.Black;
            this.paneldoktor.Location = new System.Drawing.Point(5, 178);
            this.paneldoktor.Name = "paneldoktor";
            this.paneldoktor.Size = new System.Drawing.Size(155, 40);
            this.paneldoktor.TabIndex = 8;
            this.paneldoktor.Text = "Doktor Paneli";
            this.paneldoktor.UseVisualStyleBackColor = false;
            this.paneldoktor.Click += new System.EventHandler(this.paneldoktor_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.White;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitbtn.Location = new System.Drawing.Point(169, 224);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(155, 40);
            this.exitbtn.TabIndex = 7;
            this.exitbtn.Text = "Çıkış ";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // pnlrandevuliste
            // 
            this.pnlrandevuliste.BackColor = System.Drawing.Color.White;
            this.pnlrandevuliste.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlrandevuliste.ForeColor = System.Drawing.Color.Black;
            this.pnlrandevuliste.Location = new System.Drawing.Point(169, 178);
            this.pnlrandevuliste.Name = "pnlrandevuliste";
            this.pnlrandevuliste.Size = new System.Drawing.Size(155, 40);
            this.pnlrandevuliste.TabIndex = 6;
            this.pnlrandevuliste.Text = "Randevu Listesi";
            this.pnlrandevuliste.UseVisualStyleBackColor = false;
            this.pnlrandevuliste.Click += new System.EventHandler(this.pnlrandevuliste_Click);
            // 
            // sekreteradsoyadlbl
            // 
            this.sekreteradsoyadlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sekreteradsoyadlbl.Location = new System.Drawing.Point(175, 110);
            this.sekreteradsoyadlbl.Name = "sekreteradsoyadlbl";
            this.sekreteradsoyadlbl.Size = new System.Drawing.Size(215, 30);
            this.sekreteradsoyadlbl.TabIndex = 4;
            this.sekreteradsoyadlbl.Text = "NULL NULL";
            // 
            // sekretertclbl
            // 
            this.sekretertclbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sekretertclbl.Location = new System.Drawing.Point(175, 50);
            this.sekretertclbl.Name = "sekretertclbl";
            this.sekretertclbl.Size = new System.Drawing.Size(215, 30);
            this.sekretertclbl.TabIndex = 3;
            this.sekretertclbl.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC kimlik no :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnduyuruolustur);
            this.groupBox2.Controls.Add(this.duyururichtxtbox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(3, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 369);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnduyuruolustur
            // 
            this.btnduyuruolustur.BackColor = System.Drawing.Color.White;
            this.btnduyuruolustur.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnduyuruolustur.ForeColor = System.Drawing.Color.Black;
            this.btnduyuruolustur.Location = new System.Drawing.Point(77, 320);
            this.btnduyuruolustur.Name = "btnduyuruolustur";
            this.btnduyuruolustur.Size = new System.Drawing.Size(155, 40);
            this.btnduyuruolustur.TabIndex = 10;
            this.btnduyuruolustur.Text = "Oluştur";
            this.btnduyuruolustur.UseVisualStyleBackColor = false;
            this.btnduyuruolustur.Click += new System.EventHandler(this.btnduyuruolustur_Click);
            // 
            // duyururichtxtbox
            // 
            this.duyururichtxtbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duyururichtxtbox.Location = new System.Drawing.Point(2, 32);
            this.duyururichtxtbox.Name = "duyururichtxtbox";
            this.duyururichtxtbox.Size = new System.Drawing.Size(324, 282);
            this.duyururichtxtbox.TabIndex = 0;
            this.duyururichtxtbox.Text = "";
            this.duyururichtxtbox.TextChanged += new System.EventHandler(this.duyururichtxtbox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(684, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 321);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(324, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(684, 327);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 323);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(324, 291);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox5.Controls.Add(this.btnrandevukaydet);
            this.groupBox5.Controls.Add(this.randevudoktorcmb);
            this.groupBox5.Controls.Add(this.randevubranscmb);
            this.groupBox5.Controls.Add(this.randevusaat);
            this.groupBox5.Controls.Add(this.randevutarih);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(336, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 647);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Randevu Paneli";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // btnrandevukaydet
            // 
            this.btnrandevukaydet.BackColor = System.Drawing.Color.White;
            this.btnrandevukaydet.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrandevukaydet.ForeColor = System.Drawing.Color.Black;
            this.btnrandevukaydet.Location = new System.Drawing.Point(152, 331);
            this.btnrandevukaydet.Name = "btnrandevukaydet";
            this.btnrandevukaydet.Size = new System.Drawing.Size(190, 33);
            this.btnrandevukaydet.TabIndex = 11;
            this.btnrandevukaydet.Text = "Kaydet";
            this.btnrandevukaydet.UseVisualStyleBackColor = false;
            this.btnrandevukaydet.Click += new System.EventHandler(this.btnrandevukaydet_Click);
            // 
            // randevudoktorcmb
            // 
            this.randevudoktorcmb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevudoktorcmb.FormattingEnabled = true;
            this.randevudoktorcmb.Location = new System.Drawing.Point(152, 261);
            this.randevudoktorcmb.Name = "randevudoktorcmb";
            this.randevudoktorcmb.Size = new System.Drawing.Size(190, 35);
            this.randevudoktorcmb.TabIndex = 46;
            // 
            // randevubranscmb
            // 
            this.randevubranscmb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevubranscmb.FormattingEnabled = true;
            this.randevubranscmb.Location = new System.Drawing.Point(152, 191);
            this.randevubranscmb.Name = "randevubranscmb";
            this.randevubranscmb.Size = new System.Drawing.Size(190, 35);
            this.randevubranscmb.TabIndex = 45;
            this.randevubranscmb.SelectedIndexChanged += new System.EventHandler(this.randevubranscmb_SelectedIndexChanged);
            // 
            // randevusaat
            // 
            this.randevusaat.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevusaat.Location = new System.Drawing.Point(152, 121);
            this.randevusaat.Mask = "00:00";
            this.randevusaat.Name = "randevusaat";
            this.randevusaat.Size = new System.Drawing.Size(190, 33);
            this.randevusaat.TabIndex = 44;
            this.randevusaat.ValidatingType = typeof(System.DateTime);
            // 
            // randevutarih
            // 
            this.randevutarih.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevutarih.Location = new System.Drawing.Point(152, 51);
            this.randevutarih.Mask = "00/00/0000";
            this.randevutarih.Name = "randevutarih";
            this.randevutarih.Size = new System.Drawing.Size(190, 33);
            this.randevutarih.TabIndex = 43;
            this.randevutarih.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Doktor :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Branş :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saat :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarih :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormSekreterDetay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1017, 653);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormSekreterDetay";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detaylarınız";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSekreterDetay_FormClosing);
            this.Load += new System.EventHandler(this.FormSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pnlbrans;
        private System.Windows.Forms.Button paneldoktor;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button pnlrandevuliste;
        private System.Windows.Forms.Label sekreteradsoyadlbl;
        private System.Windows.Forms.Label sekretertclbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnduyuruolustur;
        private System.Windows.Forms.RichTextBox duyururichtxtbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox randevusaat;
        private System.Windows.Forms.MaskedTextBox randevutarih;
        private System.Windows.Forms.ComboBox randevudoktorcmb;
        private System.Windows.Forms.ComboBox randevubranscmb;
        private System.Windows.Forms.Button btnrandevukaydet;
    }
}