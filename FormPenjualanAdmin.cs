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
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            FormReportPenjualan frmReport = new FormReportPenjualan();
            frmReport.ShowDialog();
        }
    }
}
