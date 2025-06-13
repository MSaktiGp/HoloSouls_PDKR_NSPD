using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HoloSouls_PDKR_NSPD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT password, role FROM users WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string hashFromDb = reader.GetString("Password");
                        string role = reader.GetString("role");
                        bool isValid = BCrypt.Net.BCrypt.Verify(password, hashFromDb);

                        if (isValid)
                        {
                            // Login sukses
                            MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (role == "admin")
                            {
                                FormMainAdmin frmAdmin = new FormMainAdmin();
                                this.Hide();
                                frmAdmin.Show();
                            }
                            else if (role == "user")
                            {
                                FormAwalCust frmAwal = new FormAwalCust();
                                this.Hide();
                                frmAwal.Show();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Password salah!", "Login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username tidak ditemukan!", "Login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan koneksi:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
