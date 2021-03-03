using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBLL;
using HotelModel;
using System.Data.SqlClient;

namespace HotelClient
{
    public partial class FrmHotelServices : Form
    {
        public DataTable Data;
        public string name;
        public string jin;
        HotelServiceBusinessLayer hotel = new HotelServiceBusinessLayer();
        public FrmHotelServices()
        {
            InitializeComponent();
        }

        private void FrmHotelServices_Load(object sender, EventArgs e)
        {
            List<CommodityTable> tables = hotel.tables();
            dataGridView1.DataSource = tables;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            FrmShoppingCartForm frmHotel = new FrmShoppingCartForm();
            frmHotel.Show();
        }

        private void 加入购物车ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否加入购物车"+this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString()+"?","购物车提示",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CommodityTable commodityTable = new CommodityTable()
                {
                    PicturePath = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),//图片
                    CommodityName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),//商品名称
                    CommodityUnit = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                    Retail= (double)dataGridView1.SelectedRows[0].Cells[3].Value
                };
                Info.tables.Add(commodityTable);
            }
        }

        private void 购买ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPayment fp = new FrmPayment();
            name = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            fp.yuan = name;
            jin = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            fp.jin = jin;
            fp.Show();
        }
    }
}

