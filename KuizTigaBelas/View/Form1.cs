using KuizTigaBelas.Controller;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace KuizTigaBelas
{
    public partial class FormProfil : Form
    {
        private DataPelatihan dtp;
        public FormProfil()
        {
            dtp = new DataPelatihan();
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtp.searchProfil(txtSearch.Text);
            dataGridView1.DataSource = dtp.searchProfil(txtSearch2.Text);
            dataGridView1.RowTemplate.Height = 80;
        }

        public void tampil()
        {
            dataGridView1.DataSource = dtp.tampilProfil(new MySqlCommand("SELECT * FROM pegawai"));
        }

        private void FormProfil_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch2.Text = "";
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
           if(rbtnAll.Checked)
            {
                DataPelatihan dtp = new DataPelatihan();
                dataGridView1.DataSource = dtp.tampilAll();
            }
        }

        private void rbtnMuslim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMuslim.Checked)
            {
                DataPelatihan dtp = new DataPelatihan();
                dataGridView1.DataSource = dtp.tampilMuslim();
            }
        }

        private void rbtnKristen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKristen.Checked)
            {
                DataPelatihan dtp = new DataPelatihan();
                dataGridView1.DataSource = dtp.tampilAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataPelatihan dtp = new DataPelatihan();
            try
            {
                dtp.hapusProfil(txtSearch2.Text);
                MessageBox.Show("Berhasil dihapus", "delete data" + MessageBoxButtons.OK);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
