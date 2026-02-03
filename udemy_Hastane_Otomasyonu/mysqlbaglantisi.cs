using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace udemy_Hastane_Otomasyonu
{
    internal class mysqlbaglantisi
    {
        public MySqlConnection baglanti()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost; Database=hastane_proje; Uid=root; Pwd = xxxxx");
            con.Open();
            return con;
        }
    }
}
