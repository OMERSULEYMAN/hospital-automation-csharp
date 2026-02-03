using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace udemy_Hastane_Otomasyonu
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }



        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            linkLabel1.Text = "Soru ve sorunlarınız için xxxxx@xxxxx.com adresimizi kullanarak bize ulaşabilirsiniz.";

            int start = linkLabel1.Text.IndexOf("xxxxx@xxxxx.com");
            int length = "xxxxx@xxxxx.com".Length;

            linkLabel1.Links.Add(start, length, "xxxxx@xxxxx.com");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uye_link_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaKayit fr = new FormHastaKayit();
            fr.Show();
            this.Hide();
        }

        private void btn_doktor_giris_Click(object sender, EventArgs e)
        {
            FormDoktorGiris fr = new FormDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void btn_sekreter_giris_Click(object sender, EventArgs e)
        {
            FormSekreterGiris fr = new FormSekreterGiris();
            fr.Show();
            this.Hide();    
        }

        mysqlbaglantisi bgl = new mysqlbaglantisi();
        private void btn_hasta_giris_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("Select * From tbl_hasta Where hastatc=@p1 and hastasifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", hasta_tc.Text);
            komut.Parameters.AddWithValue("p2", hasta_sifre.Text);
            MySqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            { 
              FormHastaDetay fr = new FormHastaDetay();
              fr.tc = hasta_tc.Text;
              fr.Show();
              this.Hide();
            }
            else 
            {
                MessageBox.Show("Tc numaranız veya şifreniz yanlış!","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void FormGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
