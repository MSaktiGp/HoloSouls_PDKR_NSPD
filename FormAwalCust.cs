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
    public partial class FormAwalCust : Form
    {
        private int id_user;
        public FormAwalCust(int userId)
        {
            InitializeComponent();
            id_user = userId;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            this.Hide();
            lgn.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormMainUser frmMain = new FormMainUser(id_user); // ✅ kirim id_user ke FormMainUser
            frmMain.Show();
            this.Hide();
        }
    }
}
