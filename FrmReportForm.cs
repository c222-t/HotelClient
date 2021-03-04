using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelModel;
using HotelBLL;
using HotelRegulator;

namespace HotelClient
{
    public partial class FrmReportForm : Form
    {
        ReportBusinessLayerManager report = new ReportBusinessLayerManager();

        public string IDCard1;
        public FrmReportForm()
        {
            InitializeComponent();
        }

        private void FrmReportForm_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE);
            List<StatementOfAccount> ofAccounts = report.Soa(IDCard1);
            dataGridView1.DataSource = ofAccounts;
        }
    }
}
