namespace udemy_Hastane_Otomasyonu
{
    partial class FormBransPaneli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnbranssil = new System.Windows.Forms.Button();
            this.btnbransguncelle = new System.Windows.Forms.Button();
            this.btnbransekle = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.bransad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bransid = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(45, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 443);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(478, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 443);
            this.panel2.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnbranssil);
            this.panel3.Controls.Add(this.btnbransguncelle);
            this.panel3.Controls.Add(this.btnbransekle);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.bransad);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.bransid);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(487, 437);
            this.panel3.TabIndex = 32;
            // 
            // btnbranssil
            // 
            this.btnbranssil.BackColor = System.Drawing.Color.White;
            this.btnbranssil.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbranssil.Location = new System.Drawing.Point(190, 381);
            this.btnbranssil.Name = "btnbranssil";
            this.btnbranssil.Size = new System.Drawing.Size(130, 40);
            this.btnbranssil.TabIndex = 39;
            this.btnbranssil.Text = "Sil";
            this.btnbranssil.UseVisualStyleBackColor = false;
            this.btnbranssil.Click += new System.EventHandler(this.btnbranssil_Click);
            // 
            // btnbransguncelle
            // 
            this.btnbransguncelle.BackColor = System.Drawing.Color.White;
            this.btnbransguncelle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbransguncelle.Location = new System.Drawing.Point(342, 381);
            this.btnbransguncelle.Name = "btnbransguncelle";
            this.btnbransguncelle.Size = new System.Drawing.Size(130, 40);
            this.btnbransguncelle.TabIndex = 38;
            this.btnbransguncelle.Text = "Güncelle";
            this.btnbransguncelle.UseVisualStyleBackColor = false;
            this.btnbransguncelle.Click += new System.EventHandler(this.btnbransguncelle_Click);
            // 
            // btnbransekle
            // 
            this.btnbransekle.BackColor = System.Drawing.Color.White;
            this.btnbransekle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbransekle.Location = new System.Drawing.Point(39, 381);
            this.btnbransekle.Name = "btnbransekle";
            this.btnbransekle.Size = new System.Drawing.Size(130, 40);
            this.btnbransekle.TabIndex = 40;
            this.btnbransekle.Text = "Ekle";
            this.btnbransekle.UseVisualStyleBackColor = false;
            this.btnbransekle.Click += new System.EventHandler(this.btnbransekle_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(3, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 42);
            this.label12.TabIndex = 32;
            this.label12.Text = "Branş id :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bransad
            // 
            this.bransad.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bransad.ForeColor = System.Drawing.Color.Black;
            this.bransad.Location = new System.Drawing.Point(254, 212);
            this.bransad.Name = "bransad";
            this.bransad.Size = new System.Drawing.Size(221, 42);
            this.bransad.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 42);
            this.label11.TabIndex = 33;
            this.label11.Text = "Branş ad :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bransid
            // 
            this.bransid.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bransid.ForeColor = System.Drawing.Color.Red;
            this.bransid.Location = new System.Drawing.Point(254, 142);
            this.bransid.Name = "bransid";
            this.bransid.Size = new System.Drawing.Size(221, 42);
            this.bransid.TabIndex = 41;
            this.bransid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bransid_KeyPress);
            // 
            // FormBransPaneli
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1017, 653);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "FormBransPaneli";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branş Ekle Sil";
            this.Load += new System.EventHandler(this.FormBransPaneli_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnbranssil;
        private System.Windows.Forms.Button btnbransguncelle;
        private System.Windows.Forms.Button btnbransekle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox bransad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox bransid;
    }
}