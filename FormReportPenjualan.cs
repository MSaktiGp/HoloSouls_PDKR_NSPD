using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class FormReportPenjualan : Form
    {
        public FormReportPenjualan()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FormReportPenjualan_Load(object sender, EventArgs e)
        {
            ReportPenjualan report = new ReportPenjualan();

            ConnectionInfo connInfo = new ConnectionInfo();
            connInfo.ServerName = "localhost";
            connInfo.DatabaseName = "nasipadang_db";
            connInfo.UserID = "root";
            connInfo.Password = "";

            // Apply ke semua tabel di report
            foreach (Table table in report.Database.Tables)
            {
                TableLogOnInfo logonInfo = table.LogOnInfo;
                logonInfo.ConnectionInfo = connInfo;
                table.ApplyLogOnInfo(logonInfo);

                // Pastikan location kosong jika perlu (kadang tersimpan path lama)
                table.Location = table.Name;
            }

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
