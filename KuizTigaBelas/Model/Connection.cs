using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuizTigaBelas.Model
{
    internal class Connection
    {
        //Agar dapat memaakai perintah sql
        public MySqlCommand cmd;
        //Perintah di codingan disimpan ke database
        public DataSet ds;
        public MySqlDataAdapter da;

        //Method u/ connect
        public MySqlConnection GetConn()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user=root;database=profil";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal " + ex.Message);
            }
            return conn;
        }
    }
}
