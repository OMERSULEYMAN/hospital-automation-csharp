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
    public partial class FormHastaKayit : Form
    {
        public FormHastaKayit()
        {
            InitializeComponent();
        }

        private void Form_hasta_kayit_Load(object sender, EventArgs e)
        {
            
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            FormGiris fr = new FormGiris();
            fr.Show();
            this.Hide();
        }

        mysqlbaglantisi bgl = new mysqlbaglantisi();
        private void btn_hasta_kaydet_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("insert into tbl_hasta(hastaad,hastasoyad,hastatc,hastatelefon,hastasifre,hastacinsiyyet) values(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", hastaad_txt.Text);
            komut.Parameters.AddWithValue("@p2", hastasoyad_txt.Text);
            komut.Parameters.AddWithValue("@p3", hst_masked_tc.Text);
            komut.Parameters.AddWithValue("@p4", hst_tel_txt.Text);
            komut.Parameters.AddWithValue("@p5", hst_sifre_txt.Text);
            komut.Parameters.AddWithValue("@p6", hst_cinsiyyet_cmb.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Oluşturuldu.","System Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            hastaad_txt.Text = "";
            hastasoyad_txt.Text = "";
            hst_masked_tc.Text = "";
            hst_tel_txt.Text = "";
            hst_sifre_txt.Text = "";
            hst_cinsiyyet_cmb.Text = "";
            hastaad_txt.Focus();

        }

        private void FormHastaKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
