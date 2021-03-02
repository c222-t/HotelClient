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
        public FrmShoppingCartForm()
        {
            InitializeComponent();
        }

        private void FrmShoppingCartForm_Load(object sender, EventArgs e)
        {
            /*FrmHotelServices frmHotel = new FrmHotelServices();
            this.textBox1.Text = frmHotel.Data;*/
            FrmHotelServices frmHotel = new FrmHotelServices();
            
            yuan = frmHotel.Data.Copy();
            this.dataGridView1.DataSource = yuan;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
