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
    public partial class FormBransPaneli : Form
    {
        public FormBransPaneli()
        {
            InitializeComponent();
        }

        mysqlbaglantisi bgl = new mysqlbaglantisi();
        private void FormBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter dr = new MySqlDataAdapter("Select * from branslar", bgl.baglanti());
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

        }

        private void btnbransekle_Click(object sender, EventArgs e)
        {
            MySqlCommand bransekle = new MySqlCommand("insert into branslar(BransAd) values(@d1)", bgl.baglanti());
            bransekle.Parameters.AddWithValue("@d1", bransad.Text);
            bransekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bransad.Text = "";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            bransid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bransad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnbranssil_Click(object sender, EventArgs e)
        {
            MySqlCommand branssil = new MySqlCommand("delete from branslar where BransID=@d1", bgl.baglanti());
            branssil.Parameters.AddWithValue("@d1", bransid.Text);
            branssil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bransad.Text = "";
            bransid.Text = "";

        }

        private void btnbransguncelle_Click(object sender, EventArgs e)
        {
            MySqlCommand bransguncelle = new MySqlCommand("update branslar set BransAd=@d2 where BransID=@d1", bgl.baglanti());
            bransguncelle.Parameters.AddWithValue("@d1", bransid.Text);
            bransguncelle.Parameters.AddWithValue("@d2", bransad.Text);
            bransguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş adı güncellendi.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bransad.Text = "";
            bransid.Text = "";
        }

        private void bransid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
