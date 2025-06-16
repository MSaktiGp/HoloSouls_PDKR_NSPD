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
    public partial class FormAdminMenu: Form
    {
        private int selectedId = -1;
        public FormAdminMenu()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                { 
                    conn.Open();
                    string query = "SELECT * FROM menu";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMenu.DataSource = dt;
                    dgvMenu.Columns["updated_at"].Visible = false;


                    dgvMenu.Columns["id_menu"].HeaderText = "ID";
                    dgvMenu.Columns["id_menu"].Visible = false;

                    dgvMenu.Columns["nama_menu"].HeaderText = "Nama";
                    dgvMenu.Columns["harga"].HeaderText = "Harga";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error load data: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            txtNama.Clear();
            txtHarga.Clear();
            selectedId = -1;
            btnCreate.Enabled = true;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        private void label1Menu_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtHarga.Text = "";
        }

       
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            string namaMenu = txtNama.Text.Trim();
            string hargaText = txtHarga.Text.Trim();

            if (string.IsNullOrEmpty(namaMenu) || string.IsNullOrEmpty(hargaText))
            {
                MessageBox.Show("Isi semua data menu!");
                return;
            }

            if (!decimal.TryParse(hargaText, out decimal harga))
            {
                MessageBox.Show("Harga harus berupa angka.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
                {
                    conn.Open();
                    string query = "INSERT INTO menu (nama_menu, harga, updated_at) VALUES (@nama, @harga, NOW())";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", namaMenu);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Menu berhasil ditambahkan!");
                LoadData(); // reload ulang isi dgvMenu
                ClearForm(); // kosongkan textbox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message);
            }
        }

       


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            DialogResult result = MessageBox.Show(
                                       "Yakin ingin menghapus menu ini?",
                                       "Konfirmasi",
                                       MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "delete from menu where id_menu=@id_menu";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_menu", selectedId);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Menu berhasil dihapus!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal hapus: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE menu SET nama_menu = @nama_menu, harga = @harga WHERE id_menu = @id_menu";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_menu", selectedId);
                    cmd.Parameters.AddWithValue("@nama_menu", txtNama.Text);
                    cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Data menu berhasil disimpan!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal simpan: " + ex.Message);
                }
            }
        }

        private void FormAdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        



        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object valueSelectedId = dgvMenu.Rows[e.RowIndex].Cells["id_menu"].Value;
                selectedId = (valueSelectedId != null && valueSelectedId != DBNull.Value)
                                ? Convert.ToInt32(valueSelectedId)
                                : -1;

                txtNama.Text = dgvMenu.Rows[e.RowIndex].Cells["nama_menu"].Value?.ToString() ?? "";
                txtHarga.Text = dgvMenu.Rows[e.RowIndex].Cells["harga"].Value?.ToString() ?? "";
                btnCreate.Enabled = false;
            }
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Judul wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                MessageBox.Show("Penulis wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHarga.Focus();
                return false;
            }

            if (!int.TryParse(txtHarga.Text, out int harga))
            {
                MessageBox.Show("Harga harus berupa angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHarga.Focus();
                return false;
            }

            if (harga < 1000 || harga > 100000)
            {
                MessageBox.Show("Harga harus antara 1000 sampai 100000!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHarga.Focus();
                return false;
            }

            return true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMainAdmin frmAwalAdmin = new FormMainAdmin();
            this.Hide();
            frmAwalAdmin.Show();
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
