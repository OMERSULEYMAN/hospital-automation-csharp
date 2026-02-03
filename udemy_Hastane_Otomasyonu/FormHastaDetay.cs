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
using System.Data.Entity;

namespace udemy_Hastane_Otomasyonu
{
    public partial class FormHastaDetay : Form
    {
        public FormHastaDetay()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        
        private void exitbtn_Click(object sender, EventArgs e)
        {
            FormGiris fr = new FormGiris();
            fr.Show();
            this.Hide();
        }

        public string tc,adsoyad,telefon;
        mysqlbaglantisi bgl = new mysqlbaglantisi();
        FormHastaGuncelle frm = new FormHastaGuncelle();
        private void FormHastaDetay_Load(object sender, EventArgs e)
        {
            // Select name, surname, phone number

            tclbl.Text = tc;
            MySqlCommand komut = new MySqlCommand("Select hastaad,hastasoyad,hastatelefon from tbl_hasta where hastatc = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",tclbl.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {

                adsoyadlbl.Text = dr[0] + " " + dr[1];
                telefonlbl.Text = dr[2].ToString();
            
            }
            bgl.baglanti().Close();

            //DataGrid

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select RandevuTarihi,RandevuSaati,RandevuBrans,RandevuDoktor From tbl_randevular Where RandevuHastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branslar

            MySqlCommand komut1 = new MySqlCommand("Select BransAd from branslar", bgl.baglanti());
            MySqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {

                branscmb.Items.Add(dr1[0]);

            }
            bgl.baglanti().Close();



        }

        private void branscmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // doktorlar

            doktorcmb.Items.Clear();

            MySqlCommand komut2 = new MySqlCommand("Select DoktorAd,DoktorSoyad from tbl_doktor where DoktorBrans=@c1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@c1", branscmb.Text);
            MySqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {

                doktorcmb.Items.Add(dr2[0] + " " + dr2[1]);

            }
            bgl.baglanti().Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            randevusaattxt.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString(); 

        }

        private void randevubtn_Click(object sender, EventArgs e)
        {
            MySqlCommand randevual = new MySqlCommand("Update tbl_randevular set " +
                "RandevuDurumu=1,RandevuHastaTC =@h1,HastaSikayeti=@h2" +
                " where RandevuDoktor=@h3 and RandevuSaati=@h4"
                ,bgl.baglanti());
            randevual.Parameters.AddWithValue("@h1",tclbl.Text);
            randevual.Parameters.AddWithValue("@h2",sikayettxt.Text);
            randevual.Parameters.AddWithValue("@h3",doktorcmb.Text);
            randevual.Parameters.AddWithValue("@h4",randevusaattxt.Text);
            randevual.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı.","Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            branscmb.Text = "";
            doktorcmb.Text = "";
            sikayettxt.Text = "";
            randevusaattxt.Text = "";
        }

        private void FormHastaDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void doktorcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(
            "SELECT RandevuTarihi, RandevuSaati, RandevuBrans, RandevuDoktor, RandevuDurumu " +
            "FROM tbl_randevular " +
            "WHERE RandevuBrans='" + branscmb.Text +
            "' AND RandevuDoktor='" + doktorcmb.Text +
            "' AND RandevuDurumu=0",
            bgl.baglanti());


            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }

        private void düzenlebtn_Click(object sender, EventArgs e)
        {
            FormHastaGuncelle fr = new FormHastaGuncelle();
            fr.tcno = tclbl.Text;
            fr.Show();
            this.Hide();
        }
    }
}
