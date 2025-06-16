using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloSouls_PDKR_NSPD
{
    public partial class FormPenjualanAdmin: Form
    {
        public FormPenjualanAdmin()
        {
            InitializeComponent();
            loadData();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            FormReportPenjualan frmReport = new FormReportPenjualan();
            frmReport.ShowDialog();
        }

        private void loadData()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM view_laporan_penjualan";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPenjualan.DataSource = dt;
                    dgvPenjualan.Columns["tanggal"].HeaderText = "Tanggal";
                    dgvPenjualan.Columns["nama_menu"].HeaderText = "Nama Menu";
                    dgvPenjualan.Columns["total_jumlah"].HeaderText = "Total Menu Terjual";
                    dgvPenjualan.Columns["total_penjualan"].HeaderText = "Total Penjualan";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error load data: " + ex.Message);
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMainAdmin frmMainAdmin = new FormMainAdmin();
            this.Hide();
            frmMainAdmin.Show();
        }
    }
}
