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
    public partial class FormDoktorGiris : Form
    {
        public FormDoktorGiris()
        {
            InitializeComponent();
        }

        mysqlbaglantisi bgl = new mysqlbaglantisi();
        private void FormDoktorGiris_Load(object sender, EventArgs e)
        {
           
           
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            FormGiris fr = new FormGiris();
            fr.Show();
            this.Hide();
        }

        private void btn_doktor_giris_Click(object sender, EventArgs e)
        {
            MySqlCommand giris = new MySqlCommand("Select * from tbl_doktor where DoktorTC = @p1 and DoktorSifre = @p2",bgl.baglanti());
            giris.Parameters.AddWithValue("@p1", doktor_tc.Text);
            giris.Parameters.AddWithValue("@p2", doktor_sifre.Text);
            MySqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            { 
              FormDoktorDetay fr = new FormDoktorDetay();
              fr.TC = doktor_tc.Text;
              fr.Show();
              this.Hide();               
            }
            else
            {
                MessageBox.Show("TC veya şifre hatalı!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void FormDoktorGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
