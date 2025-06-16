using HoloSouls_PDKR_NSPD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoloSouls_PDKR_NSPD.Models;
using MySql.Data.MySqlClient;

namespace HoloSouls_PDKR_NSPD
{
    public partial class FormMainUser: Form
    {
        private Timer refreshTimer = new Timer();
        private int lastRowCount = -1;
        private DateTime lastUpdateTime = DateTime.MinValue;

        public FormMainUser()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        { }


        private void button6_Click(object sender, EventArgs e)
        {
            FormStruk frmStruk = new FormStruk();
            this.Hide();
            frmStruk.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormAwalCust frmAwal = new FormAwalCust();
            this.Hide();
            frmAwal.Show();
        }

        private void dgvMenuCust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadMenu()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                string query = "SELECT * FROM menu";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvMenuCust.DataSource = dt;
                lastRowCount = dt.Rows.Count;

                dgvMenuCust.Columns["id_menu"].Visible = false;
                dgvMenuCust.Columns["updated_at"].Visible = false;
            }
        }

        private void FormMainUser_Load(object sender, EventArgs e)
        {
            LoadMenu();
            StartAutoRefresh();
        }

        private void StartAutoRefresh()
        {
            refreshTimer.Interval = 5000; // setiap 5 detik
            refreshTimer.Tick += RefreshTimer1_Tick;
            refreshTimer.Start();
        }

        private void RefreshTimer1_Tick(object sender, EventArgs e)
        {
            DateTime latestUpdateTime = GetLatestUpdatedAt();

            if (latestUpdateTime > lastUpdateTime)
            {
                LoadMenu();
                lastUpdateTime = latestUpdateTime;
            }
        }

        private DateTime GetLatestUpdatedAt()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT MAX(updated_at) FROM menu", conn);
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDateTime(result) : DateTime.MinValue;
            }
        }

        private int GetMenuRowCount()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM menu", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
