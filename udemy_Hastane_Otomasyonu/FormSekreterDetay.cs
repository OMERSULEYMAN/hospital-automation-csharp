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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace udemy_Hastane_Otomasyonu
{
    public partial class FormSekreterDetay : Form
    {
        public FormSekreterDetay()
        {
            InitializeComponent();
        }

        public string TC;
        mysqlbaglantisi bgl = new mysqlbaglantisi();
        private void FormSekreterDetay_Load(object sender, EventArgs e)
        {
            sekretertclbl.Text = TC;    
            MySqlCommand komut = new MySqlCommand("Select sekreteradsoyad from tbl_sekreter where sekretertc = @p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",sekretertclbl.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            { 
              sekreteradsoyadlbl.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            // branslar

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select BransAd from branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //doktor

            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter("Select CONCAT(DoktorAd, ' ' ,DoktorSoyad) as AdSoyad,DoktorBrans from tbl_doktor", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;

            //branslar combobox

            MySqlCommand komut2 = new MySqlCommand("Select BransAd from branslar", bgl.baglanti());
            MySqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {

                randevubranscmb.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();


        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            FormGiris gr = new FormGiris();
            gr.Show();
            this.Hide();
        }

        private void btnrandevukaydet_Click(object sender, EventArgs e)
        {
            MySqlCommand komutrv = new MySqlCommand("insert into tbl_randevular(RandevuTarihi,RandevuSaati,RandevuBrans,RandevuDoktor) values(@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutrv.Parameters.AddWithValue("@r1", randevutarih.Text);
            komutrv.Parameters.AddWithValue("@r2", randevusaat.Text);
            komutrv.Parameters.AddWithValue("@r3", randevubranscmb.Text);
            komutrv.Parameters.AddWithValue("@r4", randevudoktorcmb.Text);
            komutrv.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Eklendi.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            randevutarih.Text = "";
            randevusaat.Text = "";
            randevubranscmb.Text = "";
            randevudoktorcmb.Text = "";
          
        }

        private void randevubranscmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            randevudoktorcmb.Items.Clear();

            MySqlCommand komut3 = new MySqlCommand("Select DoktorAd,DoktorSoyad from tbl_doktor where DoktorBrans=@c1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@c1", randevubranscmb.Text);
            MySqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {

                randevudoktorcmb.Items.Add(dr3[0] + " " + dr3[1]);

            }
            bgl.baglanti().Close();
        }

        private void btnduyuruolustur_Click(object sender, EventArgs e)
        {
            MySqlCommand komutduyuru = new MySqlCommand("insert into tbl_duyuru (Duyuru) values(@d1)", bgl.baglanti());
            komutduyuru.Parameters.AddWithValue("@d1", duyururichtxtbox.Text);
            komutduyuru.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Duyuru Oluşturuldu!","Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            duyururichtxtbox.Text = " ";
        }

        private void duyururichtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlrandevuliste_Click(object sender, EventArgs e)
        {
            FormRandevuListesi fr = new FormRandevuListesi();
            fr.Show();
        }

        private void paneldoktor_Click(object sender, EventArgs e)
        {
            FormDoktorPaneli fr = new FormDoktorPaneli();
            fr.Show();
        }

        private void pnlbrans_Click(object sender, EventArgs e)
        {
            FormBransPaneli fr = new FormBransPaneli();
            fr.Show();
        }

        private void FormSekreterDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
