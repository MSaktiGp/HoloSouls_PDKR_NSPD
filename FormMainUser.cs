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

namespace HoloSouls_PDKR_NSPD
{
    public partial class FormMainUser: Form
    {
        MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr);
        DataTable dtPesanan = new DataTable();
        private Timer refreshTimer = new Timer();
        private int lastRowCount = -1;
        private int id_user;
        private DateTime lastUpdateTime = DateTime.MinValue;

        public FormMainUser(int userId)
        {
            InitializeComponent();
            id_user = userId;
            BuatPesanan();
            LoadData();
            txtMenu.Enabled = false;
        }

        private void BuatPesanan()
        {
            dtPesanan.Columns.Add("id_menu", typeof(int));
            dtPesanan.Columns.Add("nama_menu", typeof(string));
            dtPesanan.Columns.Add("harga_satuan", typeof(int));
            dtPesanan.Columns.Add("jumlah", typeof(int));
            dtPesanan.Columns.Add("catatan", typeof(string));
            dgvPesanan.DataSource = dtPesanan;
            dgvPesanan.Columns["id_menu"].Visible = false;

        }

        private void dgvMenuCust_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenuCust.CurrentRow != null)
            {
                txtMenu.Text = dgvMenuCust.CurrentRow.Cells["nama_menu"].Value.ToString();
            }
        }


        private void LoadData()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM menu", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMenuCust.DataSource = dt;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        { }



        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormAwalCust frmAwal = new FormAwalCust(id_user);
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

        private void btnCari_Click(object sender, EventArgs e)
        {
            TampilkanDataFiltered();
        }

        private void TampilkanDataFiltered()
        {
            string kategori = cmbFilterBy.SelectedItem?.ToString(); 
            string hargaText = txtHarga.Text.Trim();                

            string query = "SELECT * FROM menu WHERE 1=1"; // Dasar query, 1=1 untuk mempermudah penambahan kondisi

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = conn;

                if (!string.IsNullOrEmpty(kategori))
                {
                    query += " AND nama_menu LIKE @kategori";
                    cmd.Parameters.AddWithValue("@kategori", "%" + kategori + "%");
                }

                if (decimal.TryParse(hargaText, out decimal harga))
                {
                    query += " AND harga = @harga";
                    cmd.Parameters.AddWithValue("@harga", harga);
                }

                query += " ORDER BY id_menu DESC"; // Urutkan data terbaru di atas
                cmd.CommandText = query;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMenuCust.DataSource = dt;
            }

        }


        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (dgvMenuCust.CurrentRow != null)
            {
                int id_menu = Convert.ToInt32(dgvMenuCust.CurrentRow.Cells["id_menu"].Value);
                string nama_menu = dgvMenuCust.CurrentRow.Cells["nama_menu"].Value.ToString();
                int harga = Convert.ToInt32(dgvMenuCust.CurrentRow.Cells["harga"].Value);
                int jumlah = Convert.ToInt32(numMenu.Value);
                string catatan = txtTambahan.Text;

                // Cek apakah menu sudah ditambahkan sebelumnya
                bool alreadyExists = false;
                foreach (DataRow row in dtPesanan.Rows)
                {
                    if ((int)row["id_menu"] == id_menu)
                    {
                        // Update jumlah saja
                        row["jumlah"] = Convert.ToInt32(row["jumlah"]) + jumlah;
                        alreadyExists = true;
                        break;
                    }
                }

                if (!alreadyExists)
                {
                    dtPesanan.Rows.Add(id_menu, nama_menu, harga, jumlah, catatan);
                }

                HitungTotal();
            }
        }

        private void HitungTotal()
        {
            int totalItem = 0, totalHarga = 0;
            foreach (DataRow row in dtPesanan.Rows)
            {
                int jumlah = Convert.ToInt32(row["jumlah"]);
                int harga = Convert.ToInt32(row["harga_satuan"]);
                totalItem += jumlah;
                totalHarga += jumlah * harga;
            }
            lblTotalItem.Text = $"Total Item: {totalItem}";
            lblTotalHarga.Text = $"Total Harga: Rp {totalHarga:N0}";
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (dtPesanan.Rows.Count == 0)
            {
                MessageBox.Show("Pesanan kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conn.Open();

            // Simpan ke tabel pesanan
            string insertPesanan = "INSERT INTO pesanan (id_user, tanggal) VALUES (@id_user, NOW()); SELECT LAST_INSERT_ID();";
            MySqlCommand cmd = new MySqlCommand(insertPesanan, conn);
            cmd.Parameters.AddWithValue("@id_user", id_user);
            int id_pesanan = Convert.ToInt32(cmd.ExecuteScalar());

            // Simpan detail_pesanan
            foreach (DataRow row in dtPesanan.Rows)
            {
                string insertDetail = "INSERT INTO detail_pesanan (id_pesanan, id_menu, jumlah, catatan) " +
                                      "VALUES (@id_pesanan, @id_menu, @jumlah, @catatan)";
                MySqlCommand cmdDetail = new MySqlCommand(insertDetail, conn);
                cmdDetail.Parameters.AddWithValue("@id_pesanan", id_pesanan);
                cmdDetail.Parameters.AddWithValue("@id_menu", row["id_menu"]);
                cmdDetail.Parameters.AddWithValue("@jumlah", row["jumlah"]);
                cmdDetail.Parameters.AddWithValue("@catatan", row["catatan"]);
                cmdDetail.ExecuteNonQuery();
            }

            conn.Close();

            // Panggil form struk
            FormStruk struk = new FormStruk(id_pesanan); // kirim id_pesanan agar struk tahu pesanan mana
            struk.ShowDialog();

            MessageBox.Show("Pesanan berhasil disimpan.");
            dtPesanan.Clear();
            HitungTotal();
        }
    }
}
