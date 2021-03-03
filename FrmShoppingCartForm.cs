using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelClient
{
    public partial class FrmShoppingCartForm : Form
    {
        public DataTable yuan;


        public string mingchen;
        public string danwei;
        public string jine;

        public FrmShoppingCartForm()
        {
            InitializeComponent();
        }

        private void FrmShoppingCartForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Info.tables;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);//设置背景色
            //dataGridView1.ClearSelection();
            // dataGridView1.Enabled = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
