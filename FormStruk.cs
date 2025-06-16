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
    public partial class FormStruk : Form
    {
        private int id_pesanan;
        MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr);
        public FormStruk(int idPesanan)
        {
            InitializeComponent();
            id_pesanan = idPesanan;
            LoadStruk();
        }

        private void LoadStruk()
        {
            string query = "SELECT m.nama_menu, dp.jumlah, m.harga, (dp.jumlah * m.harga) AS total " +
                           "FROM detail_pesanan dp JOIN menu m ON dp.id_menu = m.id_menu " +
                           "WHERE dp.id_pesanan = @id_pesanan";

            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@id_pesanan", id_pesanan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvStruk.DataSource = dt;

            // Hitung total item & harga
            int totalItem = 0, totalHarga = 0;
            foreach (DataRow row in dt.Rows)
            {
                totalItem += Convert.ToInt32(row["jumlah"]);
                totalHarga += Convert.ToInt32(row["total"]);
            }

            lblStrukItem.Text = $"Total Item: {totalItem}";
            lblStrukTotal.Text = $"Total Harga: Rp {totalHarga:N0}";
        }
    }
}
