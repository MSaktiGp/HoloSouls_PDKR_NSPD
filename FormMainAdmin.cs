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
    public partial class FormMainAdmin: Form
    {
        public FormMainAdmin()
        {
            InitializeComponent();
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            FormPenjualanAdmin frmPenjualan = new FormPenjualanAdmin();
            this.Hide();
            frmPenjualan.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormAdminMenu frmMenu = new FormAdminMenu();
            this.Hide();
            frmMenu.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            this.Hide();
            lgn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
