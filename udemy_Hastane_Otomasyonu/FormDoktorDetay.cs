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
    public partial class FormDoktorDetay : Form
    {
        public FormDoktorDetay()
        {
            InitializeComponent();
        }

        private void duyurubtn_Click(object sender, EventArgs e)
        {
            FormDuyurular fr = new FormDuyurular();
            fr.Show();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            FormDoktorGiris fr = new FormDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void düzenlebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void sekreterbtn_Click(object sender, EventArgs e)
        {
            FormSekreterİletisim fr = new FormSekreterİletisim();
            fr.Show();
        }

        mysqlbaglantisi bgl = new mysqlbaglantisi();
        public string TC;
        private void FormDoktorDetay_Load(object sender, EventArgs e)
        {
            doktortclbl.Text = TC;
            MySqlCommand komut = new MySqlCommand("Select DoktorAd,DoktorSoyad from tbl_doktor where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",doktortclbl.Text);
            MySqlDataReader rd = komut.ExecuteReader();
            while (rd.Read()) 
            {
                doktoradsoyadlbl.Text = rd[0].ToString() + " " + rd[1].ToString();            
            }
            bgl.baglanti().Close();



            DataTable dt = new DataTable();
            MySqlDataAdapter dr = new MySqlDataAdapter(
            "Select RandevuTarihi, RandevuSaati, RandevuBrans, RandevuHastaTC, HastaSikayeti " +
            "from tbl_randevular where RandevuDoktor = '" + doktoradsoyadlbl.Text + "'",
            bgl.baglanti()
            );
            dr.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            hastasikayetirichtxt.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void FormDoktorDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
