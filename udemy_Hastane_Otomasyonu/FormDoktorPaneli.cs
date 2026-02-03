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

namespace udemy_Hastane_Otomasyonu
{
    public partial class FormDoktorPaneli : Form
    {
        public FormDoktorPaneli()
        {
            InitializeComponent();
        }

        mysqlbaglantisi bgl =   new mysqlbaglantisi();
        private void FormDoktorPaneli_Load(object sender, EventArgs e)
        {
          DataTable dt = new DataTable();
          MySqlDataAdapter dr = new MySqlDataAdapter("Select * from tbl_doktor",bgl.baglanti());
          dr.Fill(dt);
          dataGridView1.DataSource = dt;
          dataGridView1.ClearSelection();
          dataGridView1.CurrentCell = null;

            // branslar combobox

            MySqlCommand cmd = new MySqlCommand("Select BransAd from branslar",bgl.baglanti());
            MySqlDataReader datard = cmd.ExecuteReader();
            while (datard.Read()) 
            {
                branscmb.Items.Add(datard[0]);            
            }
            bgl.baglanti().Close();
        }

        private void btndoktorekle_Click(object sender, EventArgs e)
        {
            MySqlCommand doktorekle = new MySqlCommand("insert into tbl_doktor(DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values(@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            doktorekle.Parameters.AddWithValue("@d1", doktorad_txt.Text);
            doktorekle.Parameters.AddWithValue("@d2", doktorsoyad_txt.Text);
            doktorekle.Parameters.AddWithValue("@d3", branscmb.Text);
            doktorekle.Parameters.AddWithValue("@d4", doktor_masked_tc.Text);
            doktorekle.Parameters.AddWithValue("@d5", doktor_sifre_txt.Text);
            doktorekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            doktorad_txt.Text = "";
            doktorsoyad_txt.Text = "";
            branscmb.Text = "";
            doktor_masked_tc.Text = "";
            doktor_sifre_txt.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            doktorad_txt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            doktorsoyad_txt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            branscmb.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            doktor_masked_tc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            doktor_sifre_txt.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btndoktorsil_Click(object sender, EventArgs e)
        {
            MySqlCommand doktorsil = new MySqlCommand("delete from tbl_doktor where DoktorTC=@d0",bgl.baglanti());
            doktorsil.Parameters.AddWithValue("@d0", doktor_masked_tc.Text);
            doktorsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Silindi.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doktorad_txt.Text = "";
            doktorsoyad_txt.Text = "";
            branscmb.Text = "";
            doktor_masked_tc.Text = "";
            doktor_sifre_txt.Text = "";
        }

        private void btndoktorguncelle_Click(object sender, EventArgs e)
        {
            MySqlCommand doktorguncelle = new MySqlCommand("update tbl_doktor set DoktorAd=@d1,DoktorSoyad=@d2 ,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4", bgl.baglanti());
            doktorguncelle.Parameters.AddWithValue("@d1", doktorad_txt.Text);
            doktorguncelle.Parameters.AddWithValue("@d2", doktorsoyad_txt.Text);
            doktorguncelle.Parameters.AddWithValue("@d3", branscmb.Text);
            doktorguncelle.Parameters.AddWithValue("@d4", doktor_masked_tc.Text);
            doktorguncelle.Parameters.AddWithValue("@d5", doktor_sifre_txt.Text);
            doktorguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doktorad_txt.Text = "";
            doktorsoyad_txt.Text = "";
            branscmb.Text = "";
            doktor_masked_tc.Text = "";
            doktor_sifre_txt.Text = "";
        }
    }
}
