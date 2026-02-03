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
    public partial class FormDuyurular : Form
    {
        public FormDuyurular()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        mysqlbaglantisi bgl = new mysqlbaglantisi();
        private void FormDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter("Select * from tbl_duyuru", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            FormDoktorDetay fr = new FormDoktorDetay();
            fr.Show();
            this.Hide();
        }
    }
}
