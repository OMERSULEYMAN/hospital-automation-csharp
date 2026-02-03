namespace udemy_Hastane_Otomasyonu
{
    partial class FormDoktorPaneli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btndoktorguncelle = new System.Windows.Forms.Button();
            this.btndoktorsil = new System.Windows.Forms.Button();
            this.btndoktorekle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.branscmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.doktorsoyad_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.doktor_sifre_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.doktorad_txt = new System.Windows.Forms.TextBox();
            this.doktor_masked_tc = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndoktorguncelle
            // 
            this.btndoktorguncelle.BackColor = System.Drawing.Color.White;
            this.btndoktorguncelle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndoktorguncelle.Location = new System.Drawing.Point(342, 381);
            this.btndoktorguncelle.Name = "btndoktorguncelle";
            this.btndoktorguncelle.Size = new System.Drawing.Size(130, 40);
            this.btndoktorguncelle.TabIndex = 38;
            this.btndoktorguncelle.Text = "Güncelle";
            this.btndoktorguncelle.UseVisualStyleBackColor = false;
            this.btndoktorguncelle.Click += new System.EventHandler(this.btndoktorguncelle_Click);
            // 
            // btndoktorsil
            // 
            this.btndoktorsil.BackColor = System.Drawing.Color.White;
            this.btndoktorsil.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndoktorsil.Location = new System.Drawing.Point(190, 381);
            this.btndoktorsil.Name = "btndoktorsil";
            this.btndoktorsil.Size = new System.Drawing.Size(130, 40);
            this.btndoktorsil.TabIndex = 39;
            this.btndoktorsil.Text = "Sil";
            this.btndoktorsil.UseVisualStyleBackColor = false;
            this.btndoktorsil.Click += new System.EventHandler(this.btndoktorsil_Click);
            // 
            // btndoktorekle
            // 
            this.btndoktorekle.BackColor = System.Drawing.Color.White;
            this.btndoktorekle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndoktorekle.Location = new System.Drawing.Point(39, 381);
            this.btndoktorekle.Name = "btndoktorekle";
            this.btndoktorekle.Size = new System.Drawing.Size(130, 40);
            this.btndoktorekle.TabIndex = 40;
            this.btndoktorekle.Text = "Ekle";
            this.btndoktorekle.UseVisualStyleBackColor = false;
            this.btndoktorekle.Click += new System.EventHandler(this.btndoktorekle_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.branscmb);
            this.panel3.Controls.Add(this.btndoktorsil);
            this.panel3.Controls.Add(this.btndoktorguncelle);
            this.panel3.Controls.Add(this.btndoktorekle);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.doktorsoyad_txt);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.doktor_sifre_txt);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.doktorad_txt);
            this.panel3.Controls.Add(this.doktor_masked_tc);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(487, 437);
            this.panel3.TabIndex = 32;
            // 
            // branscmb
            // 
            this.branscmb.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.branscmb.ForeColor = System.Drawing.Color.Black;
            this.branscmb.FormattingEnabled = true;
            this.branscmb.Location = new System.Drawing.Point(255, 150);
            this.branscmb.Name = "branscmb";
            this.branscmb.Size = new System.Drawing.Size(221, 43);
            this.branscmb.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 42);
            this.label1.TabIndex = 39;
            this.label1.Text = "Branş :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(4, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 42);
            this.label12.TabIndex = 32;
            this.label12.Text = "Ad :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // doktorsoyad_txt
            // 
            this.doktorsoyad_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorsoyad_txt.ForeColor = System.Drawing.Color.Black;
            this.doktorsoyad_txt.Location = new System.Drawing.Point(255, 80);
            this.doktorsoyad_txt.Name = "doktorsoyad_txt";
            this.doktorsoyad_txt.Size = new System.Drawing.Size(221, 42);
            this.doktorsoyad_txt.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(4, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 42);
            this.label11.TabIndex = 33;
            this.label11.Text = "Soyad :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // doktor_sifre_txt
            // 
            this.doktor_sifre_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktor_sifre_txt.ForeColor = System.Drawing.Color.Black;
            this.doktor_sifre_txt.Location = new System.Drawing.Point(255, 290);
            this.doktor_sifre_txt.Name = "doktor_sifre_txt";
            this.doktor_sifre_txt.Size = new System.Drawing.Size(221, 42);
            this.doktor_sifre_txt.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(4, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 42);
            this.label10.TabIndex = 34;
            this.label10.Text = "  TC kimlik no : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // doktorad_txt
            // 
            this.doktorad_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorad_txt.ForeColor = System.Drawing.Color.Black;
            this.doktorad_txt.Location = new System.Drawing.Point(255, 10);
            this.doktorad_txt.Name = "doktorad_txt";
            this.doktorad_txt.Size = new System.Drawing.Size(221, 42);
            this.doktorad_txt.TabIndex = 41;
            // 
            // doktor_masked_tc
            // 
            this.doktor_masked_tc.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktor_masked_tc.ForeColor = System.Drawing.Color.Black;
            this.doktor_masked_tc.Location = new System.Drawing.Point(255, 220);
            this.doktor_masked_tc.Mask = "00000000000";
            this.doktor_masked_tc.Name = "doktor_masked_tc";
            this.doktor_masked_tc.Size = new System.Drawing.Size(221, 42);
            this.doktor_masked_tc.TabIndex = 39;
            this.doktor_masked_tc.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 42);
            this.label7.TabIndex = 37;
            this.label7.Text = "Şifre :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(480, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 443);
            this.panel2.TabIndex = 37;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(47, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 443);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doktorlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(453, 411);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormDoktorPaneli
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1017, 653);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "FormDoktorPaneli";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Ekle Sil";
            this.Load += new System.EventHandler(this.FormDoktorPaneli_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btndoktorguncelle;
        private System.Windows.Forms.Button btndoktorsil;
        private System.Windows.Forms.Button btndoktorekle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox branscmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox doktorsoyad_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox doktor_sifre_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox doktorad_txt;
        private System.Windows.Forms.MaskedTextBox doktor_masked_tc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}