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
    public partial class FormSekreterGiris : Form
    {
        public FormSekreterGiris()
        {
            InitializeComponent();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            FormGiris fr = new FormGiris();
            fr.Show();
            this.Hide();
        }

        mysqlbaglantisi bgl = new mysqlbaglantisi();

        private void btn_doktor_giris_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("Select * From tbl_sekreter where sekretertc =@p1 and sekretersifre = @p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", sekreter_tc.Text);
            komut.Parameters.AddWithValue("@p2", sekreter_sifre.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            { 
                FormSekreterDetay fr = new FormSekreterDetay();
                fr.TC = sekreter_tc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tc veya şifre hatalı!","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void FormSekreterGiris_Load(object sender, EventArgs e)
        {

        }

        private void FormSekreterGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
