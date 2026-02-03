using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace udemy_Hastane_Otomasyonu
{
    public partial class FormHastaGuncelle : Form
    {
        public FormHastaGuncelle()
        {
            InitializeComponent();
        }

        public string tcno;
        mysqlbaglantisi bgl = new mysqlbaglantisi();

        private void btn_hasta_kaydet_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand(
              "UPDATE tbl_hasta " +
               "SET hastaad=@p1, hastasoyad=@p2, hastatelefon=@p4, hastasifre=@p5, hastacinsiyyet=@p6 " +
               "WHERE hastatc=@p0",
                bgl.baglanti());
         
            komut.Parameters.AddWithValue("@p1", hastaad_txt.Text);
            komut.Parameters.AddWithValue("@p2", hastasoyad_txt.Text);
            komut.Parameters.AddWithValue("@p4", hst_tel_txt.Text);
            komut.Parameters.AddWithValue("@p5", hst_sifre_txt.Text);
            komut.Parameters.AddWithValue("@p6", hst_cinsiyyet_cmb.Text);
            komut.Parameters.AddWithValue("@p0", hst_masked_tc.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi!","Message",MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            FormHastaDetay fr = new FormHastaDetay();
            fr.tc = hst_masked_tc.Text;
            fr.adsoyad = hastaad_txt.Text +" "+hastasoyad_txt;
            fr.telefon = hst_tel_txt.Text;
            fr.Show();
            this.Hide();
        }

        private void FormHastaGuncelle_Load(object sender, EventArgs e)
        {
            hst_masked_tc.Text = tcno;
            MySqlCommand komut1 = new MySqlCommand("Select * From tbl_hasta where hastatc = @c1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@c1",tcno);
            MySqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                hastaad_txt.Text = dr[1].ToString();
                hastasoyad_txt.Text = dr[2].ToString();
                hst_tel_txt.Text = dr[4].ToString();
                hst_sifre_txt.Text = dr[5].ToString();
                hst_cinsiyyet_cmb.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();

        }
    }
}
