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
        public FormAwalCust()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            this.Hide();
            lgn.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormMainUser frmUser = new FormMainUser();
            this.Hide();
            frmUser.Show();
        }
    }
}
