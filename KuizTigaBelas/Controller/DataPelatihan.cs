using KuizTigaBelas.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuizTigaBelas.Controller
{

    internal class DataPelatihan : Model.Connection
    {
        //private Connection conn;
        Connection conn = new Connection();
        DataPelatihan dtp;

        public DataTable tampilProfil(MySqlCommand mySqlCommand)
        {
            DataTable dt = new DataTable();
            try
            {
                string tampil = "SELECT * FROM pegawai";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable searchProfil(string search)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM pegawai WHERE CONCAT(Id,Nama,Alamat,Agama,Umur)LIKE '%" + search + "%'", conn.GetConn());
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

        public DataTable tampilAll()
        {
            DataTable dt = new DataTable();
            try
            {
                string tampil = "SELECT * FROM pegawai";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable tampilMuslim()
        {
            DataTable dt = new DataTable();
            try
            {
                string tampil = "SELECT * FROM pegawai WHERE Agama='Islam'";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable tampilKristen()
        {
            DataTable dt = new DataTable();
            try
            {
                string tampil = "SELECT * FROM pegawai WHERE Agama = 'Kristen'";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public void hapusProfil(string search)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE * FROM pegawai WHERE CONCAT(Id,Nama,Alamat,Agama,Umur)LIKE '%" + search + "%'", conn.GetConn());
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

            }
            catch (Exception ex)
            {
                MessageBox.Show("delete gagal" + ex.Message);
            }
        }

    }
}
